using System;

public class Vehicle
{
    public string Make { get; }
    public string Model { get; }

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public virtual string DisplayInfo()
    {
        return $"{Make} {Model}";
    }
}

public class Car : Vehicle
{
    public int NumDoors { get; }

    public Car(string make, string model, int numDoors) : base(make, model)
    {
        NumDoors = numDoors;
    }

    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, {NumDoors} doors";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla", 4);
        Console.WriteLine(car.DisplayInfo()); // Output: Toyota Corolla, 4 doors
    }
}
