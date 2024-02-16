namespace learning03;

public class Car 
{
    public string make;
    public string model;
    public int mileage;
    public int gallonsOfFuel;

    public Owner owner;

    public int RemainingMiles()
    {
        return gallonsOfFuel * mileage;
    }

    public void ReduceFuel(int amount)
    {
        gallonsOfFuel -= amount;
    }
}