using Ovning3FordonsHanteringsSystem.Vehicles;
namespace Ovning3FordonsHanteringsSystem;

internal static class VehicleHandler  
{
    public static HashSet<Vehicle> ListVehicles = new HashSet<Vehicle>();

    internal static void CreateVehicle(Vehicle vehicle)
    {
        ListVehicles.Add(vehicle);
    }

    internal static void UpdateBrand(Vehicle vehicle, string brand)
    {
        vehicle.Brand = brand;
    }

    internal static void UpdateModel(Vehicle vehicle, string model)
    {
        vehicle.Model = model;
    }

    internal static void UpdateVehicle(Vehicle vehicle, string brand, string model, int year, double weight)
    {
        vehicle.Brand = brand;
        vehicle.Model = model;
        vehicle.Year = year;
        vehicle.Weight = weight;
    }

    internal static void DisplayVehicles()
    {
        foreach (var vehicle in ListVehicles)
        {
            Util.Log($"{vehicle}");
        }
    }
}