using System;

class Program
{
    static void Main(string[] args)
    {
        Dealer dealer = new Dealer();
        bool keepGoing = true;

        while (keepGoing)
        {
        //   Console.Clear();
            int choice = ShowMenu();

            if (choice == 1) //Add car
            {
                dealer.AddCar();
            }
            else if (choice == 2) //List cars
            {
                Console.Clear();
                dealer.DisplayCars();
            }
            else if (choice == 3) //Save cars
            {
                var lines = dealer.Export();
                WriteFile(lines);
            }
            else if (choice == 4) //Load cars
            {
                var lines = ReadFile();
                dealer = new Dealer(lines);
            }
            else if (choice == 5) //Exit
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Car Management System");
        Console.WriteLine("---------------------");
        Console.WriteLine("   1. Add a car");
        Console.WriteLine("   2. List cars");
        Console.WriteLine("   3. Save cars");
        Console.WriteLine("   4. Load cars");
        Console.WriteLine("   5. Exit");

        Console.Write("\nEnter your choice: ");
        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
}