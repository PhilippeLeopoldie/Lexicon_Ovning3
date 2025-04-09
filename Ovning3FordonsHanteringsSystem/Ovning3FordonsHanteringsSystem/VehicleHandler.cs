using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3FordonsHanteringsSystem;

internal static class VehicleHandler
{
    private static HashSet<Vehicle> vehicles = new HashSet<Vehicle>();

    internal static Vehicle CreateVehicle()
    {
        var vehicle = new Vehicle();
        vehicles.Add(vehicle);
        Log("vehicule");
        return vehicle;
    }

    internal static void ModifyBrand()
    {
        Console.WriteLine("Which brand would you like to modify?");
        var brandToModify = Console.ReadLine();
        Console.Write("Write the new brand:");
        var newBrand = Console.ReadLine();
        var vehicle = vehicles.FirstOrDefault(vehicle => vehicle.Brand == brandToModify);
        if (vehicle != null) vehicle.Brand = newBrand;
        else Log($"No '{brandToModify}' vehicle found!");
    }

    internal static void ModifyModel(string modelToModify, string newModel)
    {
        var vehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == modelToModify);
        vehicle.Model = newModel;
    }


    private static void Log(string message)
    {
        Console.WriteLine(message);
    }
}
