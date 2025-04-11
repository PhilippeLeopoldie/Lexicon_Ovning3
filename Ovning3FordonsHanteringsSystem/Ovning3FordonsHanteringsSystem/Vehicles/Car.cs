namespace Ovning3FordonsHanteringsSystem.Vehicles;

internal class Car : Vehicle, ICleanable
{

    public double BatteryRange { get; set; }

    public Car(string brand, string model, int year, double weight, double batteryRange) : base (brand,model, year, weight)
    {
        BatteryRange = batteryRange;
    }
    
    public Car()
    {

    }
    public override string StartEngine()
    {
        return "Car started!";
    }

    public override string Stats()
    {
        return $"{this}, battery range: {BatteryRange}";
    }

    public string Clean()
    {
        return "The car is cleaned!";
    }
}
