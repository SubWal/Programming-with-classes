namespace Learning02;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        int count = 23;

        var cars = new List<Car>();

        var car = new Car("Honda", "Civic", 10, 30);

        var owner = new Person();
        owner.name = "bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);

        car = new Car("Ford", "F-150", 30, 5);

        owner = new Person();
        owner.name = "sue";
        owner.phone = "444-4444";
        car.owner = owner;

        cars.Add(car);

        Console.Clear();
        foreach (var c in cars)
        {
            // System.Console.WriteLine($"{c.make} {c.model}: totalRange = {c.TotalRange()}");
            c.Display();
            c.TotalRange();
            int range = TotalRange(c);
        }
    }

    static public int TotalRange(Car car)
    {
        return car.gallons * car.milesPerGallon;
    }
}

