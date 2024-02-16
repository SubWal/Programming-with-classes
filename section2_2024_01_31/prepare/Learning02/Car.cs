public class Car
{
    public string make;
    public string model;
    public int gallons;
    public int milesPerGallon;
    public Owner owner;

    public Car(string make, string model, int gallons, int milesPerGallon, Owner owner)
    {
        this.make = make;
        this.model = model;
        this.gallons = gallons;
        this.milesPerGallon = milesPerGallon;
        this.owner = owner;
    }

    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
    }

    public int TotalRange()
    {
        return gallons * milesPerGallon;
    }

    public void Display()
    {
        System.Console.WriteLine($"{make} {model} {owner.name}: Range= {TotalRange()}");
    }
}