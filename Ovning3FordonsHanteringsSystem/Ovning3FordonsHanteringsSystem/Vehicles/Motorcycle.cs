namespace Ovning3FordonsHanteringsSystem.Vehicles;

internal class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, string model, int year, double weight, bool hasSidecar) : base(brand, model, year, weight)
    {
        HasSidecar = hasSidecar;
    }

    public override string StartEngine()
    {
        return "Motorcycle started!";
    }

    public override string Stats()
    {
        return $"{this}, has side car: {this.HasSidecar}";
    }
}
