public class Dealer
{
    public List<Car> cars;

    public Dealer()
    {
        cars = new List<Car>();
    }

    public Dealer(string[] importLines)
    {
        cars = new List<Car>();
        foreach (var line in importLines)
        {
            var car = new Car(line);
            cars.Add(car);
        }
    }

    public void DisplayCars()
    {
        Console.WriteLine("\nCar List:");
        Console.WriteLine("---------");

        foreach (var car in cars)
        {
            Console.WriteLine(car.DisplayString());
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var car in cars)
        {
            exportLines.Add(car.Export());
        }
        return exportLines.ToArray();
    }

    public void AddCar()
    {
        Console.Write("Enter make: ");
        var make = Console.ReadLine();

        Console.Write("Enter model: ");
        var model = Console.ReadLine();

        Console.Write("Enter gallons (tank size): ");
        var gallons = int.Parse(Console.ReadLine());

        Console.Write("Enter miles per gallon: ");
        var milesPerGallon = int.Parse(Console.ReadLine());

        var car = new Car(make, model, gallons, milesPerGallon);

        cars.Add(car);
    }
}