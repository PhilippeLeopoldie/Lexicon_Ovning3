namespace Ovning3FordonsHanteringsSystem.Vehicles;

internal class ElectricScooter : Vehicle
{
    public double BatteryPower {  get; set; }

    public ElectricScooter(string brand, string model, int year, double weight, double batteryPower) : base(brand, model, year, weight)
    {
        BatteryPower = batteryPower;
    }

    public override string StartEngine()
    {
        return "Scooter started!";
    }

    public override string Stats()
    {
        return $"{this}, battery power: {this.BatteryPower}";
    }
}
