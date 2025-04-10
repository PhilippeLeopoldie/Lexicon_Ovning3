using Ovning3FordonsHanteringsSystem.Vehicles;

namespace Ovning3FordonsHanteringsSystem;

internal static class VehicleHandler
{
    private static HashSet<Vehicle> vehicles = new HashSet<Vehicle>();

    internal static void CreateVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    internal static void ModifyBrand()
    {
        Console.WriteLine("Which brand would you like to modify?");
        var brandToModify = Console.ReadLine();
        Console.Write("Write the new brand:");
        var newBrand = Console.ReadLine();
        var vehicle = vehicles.FirstOrDefault(vehicle => vehicle.Brand == brandToModify);
        if (vehicle != null) vehicle.Brand = newBrand;
        else Util.Log($"No '{brandToModify}' vehicle found!");
    }

    internal static void ModifyModel(string modelToModify, string newModel)
    {
        var vehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == modelToModify);
        vehicle.Model = newModel;
    }

    internal static void DisplayVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            Util.Log($"{vehicle}");
        }
    }
}