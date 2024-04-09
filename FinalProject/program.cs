// using System;
// using System.Collections.Generic;

// public interface IItem
// {
//     string Name { get; }
//     float Price { get; }
// }

// public class Item : IItem
// {
//     public string Name { get; }
//     public virtual float Price { get; }

//     public Item(string name, float price)
//     {
//         Name = name;
//         Price = price;
//     }
// }

// public class DiscountedItem : Item
// {
//     private readonly float _discount;

//     public DiscountedItem(string name, float price, float discount) : base(name, price)
//     {
//         _discount = discount;
//     }

//     public override float Price => base.Price - (base.Price * _discount / 100);
// }

// public class OnSaleItem : Item
// {
//     public bool OnSale { get; }

//     public OnSaleItem(string name, float price, bool onSale) : base(name, price)
//     {
//         OnSale = onSale;
//     }
// }

// public class Menu
// {
//     private readonly List<IItem> _items = new List<IItem>
//     {
//         new Item("none", 0),
//         new Item("Rice", 13.00f),
//         new Item("Cow", 14.00f),
//         new DiscountedItem("Money", 15.00f, 4),
//         new OnSaleItem("Monkey", 32.8f, true)
//     };

//     public void DisplayMenu()
//     {
//         Console.WriteLine("Item\t:\tPrice\n");
//         foreach (var item in _items)
//         {
//             Console.WriteLine($"{item.Name}\t:\t{item.Price}");
//             if (item is OnSaleItem)
//                 Console.WriteLine("(On Sale. The price is reduced)\n");
//             else if (item is DiscountedItem x)
//                 Console.WriteLine($"{x.Price}% discount in Item.\n");
//             else
//                 Console.WriteLine("\n");
//         }
//     }

//     public IItem GetItem(string name)
//     {
//         foreach (var item in _items)
//         {
//             if (item.Name == name)
//                 return item;
//         }
//         return _items[0];
//     }
// }

// public class Cart
// {
//     private readonly Dictionary<string, IItem> _cart = new Dictionary<string, IItem>();

//     public void AddToCart(string name, float price)
//     {
//         var item = new Item(name, price);
//         _cart[name] = item;
//         Console.WriteLine($"{name} added");
//         Console.WriteLine(string.Join(", ", GetItemNames()));
//     }

//     public void RemoveFromCart(string name)
//     {
//         _cart.Remove(name);
//     }

//     public List<string> GetItemNames()
//     {
//         if (_cart.Count < 1)
//         {
//             Console.WriteLine("The cart is empty");
//             return new List<string>();
//         }
//         return new List<string>(_cart.Keys);
//     }

//     // public List<float> GetPrices()
//     // {
//     //     return new List<float>(_cart.Values);
//     // }

//     public float GetTotal()
//     {
//         float total = 0.0f;
//         foreach (var item in _cart.Values)
//         {
//             total += item.Price;
//         }
//         return total;
//     }

//     public void GetCartStat()
//     {
//         Console.WriteLine("Item\t:\tPrice\n");
//         if (_cart.Count == 0)
//         {
//             Console.WriteLine("The cart is empty");
//         }
//         else
//         {
//             foreach (var item in _cart)
//             {
//                 Console.WriteLine($"{item.Key}\t: {item.Value.Price}\n");
//             }
//             LineBreak();
//             Console.WriteLine($"Total amount : {GetTotal()}");
//         }
//     }

//     private static void LineBreak()
//     {
//         Console.WriteLine(new string('~', 40));
//     }
// }

// public class Program
// {
//     private static readonly string Intro = "It is a command based self checkout section.\n" +
//                                            "You can either select any item from the given menu or put your custom item along with the price.\n" +
//                                            "At the end, it will ask you to put the payment method, you can then put in the cash amount and then it will return your change.";

//     private static readonly string Commands = "If you want to add item, type ADD\n" +
//                                                "If you want to remove item, type DEL\n" +
//                                                "If you want to checkout, type CHK\n" +
//                                                "If you want to check the cart stat, type STAT\n" +
//                                                "If you want to quit in the middle, leave the items and type QUIT\n" +
//                                                "If you don't like the service, GOOD FOR U.";

//     private static void NewLine()
//     {
//         Console.WriteLine(new string('-', 8) + "+");
//         Console.WriteLine();
//     }

//     private static string TakeInput(string prompt)
//     {
//         string input;
//         do
//         {
//             Console.Write(prompt);
//             input = Console.ReadLine();
//         } while (string.IsNullOrEmpty(input));
//         return input;
//     }

//     private static float TakeInputPrice(string prompt)
//     {
//         float price;
//         do
//         {
//             Console.Write(prompt);
//         } while (!float.TryParse(Console.ReadLine(), out price) || price <= 0);
//         return price;
//     }

//     private static void AddItems(Menu menu, Cart cart)
//     {
//         var choice = TakeInput("Do you want something from Menu or Custom (M/C)? ");
//         if (choice.ToUpper() == "M")
//         {
//             string itemMenu;
//             do
//             {
//                 itemMenu = TakeInput("What item would you like? ");
//             } while (!menu.GetItem(itemMenu).Name.Equals("none"));
//             cart.AddToCart(itemMenu, menu.GetItem(itemMenu).Price);
//         }
//         else
//         {
//             var name = TakeInput("Enter the name of Item: ");
//             var price = TakeInputPrice("Enter the price: ");
//             cart.AddToCart(name, price);
//         }
//     }

//     private static void DelItems(Menu menu, Cart cart)
//     {
//         var input = TakeInput("Enter the name of Item: ");
//         if (cart.GetItemNames().Contains(input))
//         {
//             cart.RemoveFromCart(input);
//         }
//         else
//         {
//             Console.WriteLine("Item not in cart");
//         }
//     }

//     private static void Main()
//     {
//         var options = new[] { "ADD", "DEL", "CHK", "STAT", "QUIT" };

//         Console.WriteLine(Intro);
//         NewLine();
//         var menu = new Menu();
//         NewLine();
//         var cart = new Cart();

//         while (true)
//         {
//             Console.WriteLine(Commands);
//             NewLine();
//             Console.Write("> ");
//             var value = TakeInput("Type your Command: ");
//             while (!options.Contains(value))
//             {
//                 value = TakeInput("Type your Command: ");
//             }

//             switch (value)
//             {
//                 case "ADD":
//                     AddItems(menu, cart);
//                     break;
//                 case "DEL":
//                     DelItems(menu, cart);
//                     break;
//                 case "CHK":
//                     Console.WriteLine(cart.GetTotal());
//                     var input = TakeInputPrice("Enter the payment amount: ");
//                     if (input > cart.GetTotal())
//                     {
//                         Console.WriteLine("Successful transaction. Change went to donation");
//                     }
//                     else
//                     {
//                         Console.WriteLine("More money, Dude!");
//                     }
//                     break;
//                 case "STAT":
//                     cart.GetCartStat();
//                     break;
//                 case "QUIT":
//                     Console.WriteLine("Ba-bye");
//                     return;
//             }
//             LineBreak();
//         }
//     }

//     private static void LineBreak()
//     {
//         Console.WriteLine(new string('~', 40));
//     }
// }

using System;
using System.Collections.Generic;
using System.Threading;

public interface IItem
{
    string Name { get; }
    float Price { get; }
}

public class Item : IItem
{
    public string Name { get; }
    public virtual float Price { get; }

    public Item(string name, float price)
    {
        Name = name;
        Price = price;
    }
}

public class DiscountedItem : Item
{
    private readonly float _discount;

    public DiscountedItem(string name, float price, float discount) : base(name, price)
    {
        _discount = discount;
    }

    public override float Price => base.Price - (base.Price * _discount / 100);
}

public class OnSaleItem : Item
{
    public bool OnSale { get; }

    public OnSaleItem(string name, float price, bool onSale) : base(name, price)
    {
        OnSale = onSale;
    }
}

public class Menu
{
    private readonly Dictionary<string, float> _items = new Dictionary<string, float>
    {
        { "Rice", 13.00f },
        { "Cow", 14.00f },
        { "Money", 15.00f }, // No discount specified
        { "Monkey", 32.8f },  // No sale specified
        { "Beef", 10.00f },
        { "Monster", 2.99f }, // Here you can add new item as well 
        { "RedBull", 2.99f },
        { "Milk", 3.99f },
        { "Juice", 1.99f },
       
        { "Bread", 12.99f },
        { "Eggs", 9.99f },
        { "Cheese", 15.49f },
        { "Apples", 7.99f },
        { "Bananas", 6.49f },
        { "Chicken", 17.99f },
        { "Salmon", 25.99f },
        { "Pasta", 11.99f },
        { "Potatoes", 8.49f },
        { "Tomatoes", 9.99f }
    };
public void DisplayMenu()
{
    Console.WriteLine(new string('-', 50));
    Console.WriteLine("Welcome to the POS System\n");
    Console.WriteLine("{0,-20} {1,30}", "Item", "Price");
    Console.WriteLine(new string('-', 50));

    foreach (var item in _items)
    {
        Console.WriteLine("{0,-20} {1,30:C}", item.Key, item.Value);
    }

    Console.WriteLine(new string('-', 50));
}
    // public void DisplayMenu()
    // {
    //     Console.WriteLine("Item\t:\tPrice\n");
    //     foreach (var item in _items)
    //     {
    //         Console.WriteLine($"{item.Key}\t:\t{item.Value}");
    //     }
    // }

    public IItem GetItem(string name)
    {
        if (_items.ContainsKey(name))
        {
            float price = _items[name];
            // Add logic here to handle discounted or on-sale items if needed
            return new Item(name, price);
        }
        else 
        {
            Console.WriteLine("Item not found");
            // throw new ArgumentException("Item not found ", nameof(name));
            return null;
        }
    }

public class Cart
{
    private readonly Dictionary<string, IItem> _cart = new Dictionary<string, IItem>();

    public void AddToCart(string name, float price)
    {
        var item = new Item(name, price);
        _cart[name] = item;
        Console.WriteLine($"{name} added");
        Console.WriteLine(string.Join(", ", GetItemNames()));
    }

    public void RemoveFromCart(string name)
    {
        _cart.Remove(name);
    }

    public List<string> GetItemNames()
    {
        if (_cart.Count < 1)
        {
            Console.WriteLine("The cart is empty");
            return new List<string>();
        }
        return new List<string>(_cart.Keys);
    }

    public float GetTotal()
    {
        float total = 0.0f;
        foreach (var item in _cart.Values)
        {
            total += item.Price;
        }
        return total;
    }

    public void GetCartStat()
    {
        Console.WriteLine("Item\t:\tPrice\n");
        if (_cart.Count == 0)
        {
            Console.WriteLine("The cart is empty");
        }
        else
        {
            foreach (var item in _cart)
            {
                Console.WriteLine($"{item.Key}\t: {item.Value.Price}\n");
            }
            LineBreak();
            Console.WriteLine($"Total amount : {GetTotal()}");
        }
    }

    private static void LineBreak()
    {
        Console.WriteLine(new string('~', 40));
    }
}

public class Program
{
    private static readonly string Intro = "It is a command based self checkout section.\n" +
                                           "You can either select any item from the given menu or put your custom item along with the price.\n" +
                                           "At the end, it will ask you to put the payment method, you can then put in the cash amount and then it will return your change.";

    private static readonly string Commands = "If you want to Add item in Your Cart , type ADD\n" +
                                               "If you want to Remove an Item from your Cart, type DEL\n" +
                                               "If you want to Proceed to Checkout, type CHK\n" +
                                               "If you want to check the cart stat, type STAT\n" +
                                               "If you want to quit in the middle, leave the items and type QUIT\n" 
                                               ;

    private static void NewLine()
    {
        Console.WriteLine(new string('-', 8) + "+");
        Console.WriteLine();
    }

    private static string TakeInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));
        return input;
    }

    private static float TakeInputPrice(string prompt)
    {
        float price;
        do
        {
            Console.Write(prompt);
        } while (!float.TryParse(Console.ReadLine(), out price) || price <= 0);
        return price;
    }

    private static void AddItems(Menu menu, Cart cart)
    {
        var choice = TakeInput("Do you want something from Menu or Custom (M/C)? ");
        if (choice.ToUpper() == "M")
        {
            string itemMenu;
            do
            {
                itemMenu = TakeInput("What item would you like? ");
            } while (menu.GetItem(itemMenu) == null);
            var selectedItem = menu.GetItem(itemMenu);
            cart.AddToCart(selectedItem.Name, selectedItem.Price);
        }
        else
        {
            var name = TakeInput("Enter the name of Item: ");
            var price = TakeInputPrice("Enter the price: ");
            cart.AddToCart(name, price);
        }
    }

    private static void DelItems(Menu menu, Cart cart)
    {
        var input = TakeInput("Enter the name of Item: ");
        if (cart.GetItemNames().Contains(input))
        {
            cart.RemoveFromCart(input);
        }
        else
        {
            Console.WriteLine("Item not in cart");
        }
    }

    private static void Main()
    {
        var options = new[] { "ADD", "DEL", "CHK", "STAT", "QUIT" };

        Console.WriteLine(Intro);
        NewLine();
        var menu = new Menu();
        Console.WriteLine("\nDisplaying Menu:");
        menu.DisplayMenu();
        NewLine();
        var cart = new Cart();

        while (true)
        {
            Console.WriteLine(Commands);
            NewLine();
            Console.Write("> ");
            var value = TakeInput("Type your Command: ");
            while (!options.Contains(value))
            {
                value = TakeInput("Type your Command: ");
            }

            switch (value)
            {
                case "ADD":
                    AddItems(menu, cart);
                    break;
                case "DEL":
                    DelItems(menu, cart);
                    break;
                case "CHK":
                    Console.WriteLine(cart.GetTotal());
                    var input = TakeInputPrice("Enter the payment amount: ");
                    if (input > cart.GetTotal())
                    {
                        Console.Write("Processing payment ");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(500); // Sleep for 0.5 seconds
                        }
                        Console.WriteLine();
                        float change = input - cart.GetTotal();
                        Console.WriteLine($"Change: {change:C}");
                    }
                    else
                    {
                        Console.WriteLine("More money, Dude!");
                    }
                    break;
                case "STAT":
                    cart.GetCartStat();
                    break;
                case "QUIT":
                    Console.WriteLine("Ba-bye");
                    return;
            }
            LineBreak();
        }
    }

    private static void LineBreak()
    {
        Console.WriteLine(new string('~', 40));
    }
}
}
