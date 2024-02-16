using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Xsl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        var cars = new List<Car>();

        var owner = new Owner();
        owner.name = "bob";
        owner.phone = "333-3333";

        var count = 23;

        var car = new Car("Honda", "Civic", 10, 30, owner);

        cars.Add(car);

        count = 45;
        owner = new Owner();
        owner.name = "sue";
        owner.phone = "222-2222";
        car.owner = owner;

        car = new Car("Ford", "F-150", 30, 5, owner);


        cars.Add(car);

        foreach (var c in cars)
        {
            c.Display();
            int range = c.TotalRange();
        }
    }
}



