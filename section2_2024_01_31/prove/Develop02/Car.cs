public class Car
{
    public string make;
    public string model;
    public int gallons;
    public int milesPerGallon;

    public Car(string make, string model, int gallons, int milesPerGallon)
    {
        this.make = make;
        this.model = model;
        this.gallons = gallons;
        this.milesPerGallon = milesPerGallon;
    }

    public Car(string import)
    {
        var parts = import.Split("|");
        this.make = parts[0];
        this.model = parts[1];
        this.gallons = int.Parse(parts[2]);
        this.milesPerGallon = int.Parse(parts[3]);
    }

    public string Export()
    {
        return $"{make}|{model}|{gallons}|{milesPerGallon}";
    }

    public string DisplayString()
    {
        return $"{make} {model} ({gallons} gallons, {milesPerGallon} mpg)";
    }
}