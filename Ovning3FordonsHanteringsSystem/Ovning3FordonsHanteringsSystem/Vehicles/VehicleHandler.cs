using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem.Vehicles;
using Ovning3FordonsHanteringsSystem;


public static class VehicleHandler  
{
    public static HashSet<Vehicle> ListVehicles = new HashSet<Vehicle>();

    internal static void CreateVehicle(this Vehicle vehicle)
    {
        ListVehicles.Add(vehicle);
    }


    public static Vehicle EnterNewVehicle(this Vehicle vehicle)
    {
        "----- Add a new vehicle ------".Log();
        "Enter a brand:".Log();
        vehicle.Brand = Console.ReadLine();
        vehicle.EnterVehicleProperties();
        return vehicle;
    }

    internal static void UpdateBrand(this Vehicle vehicle, string brand)
    {
        vehicle.Brand = brand;
    }

    internal static void UpdateModel(Vehicle vehicle, string model)
    {
        vehicle.Model = model;
    }

    public static void UpdateVehicleByBrand()
    {
        "Enter the brand you are looking for:".Log();
        var brand = Console.ReadLine().ToLower();
        while (ListVehicles.First(vehicle => vehicle.Brand == brand) is ArgumentNullException)
        {
            $"Vehicle {brand} not found!".Log();
            brand = Console.ReadLine();
        }
        var vehicleToUpdate = ListVehicles.First(vehicle => vehicle.Brand == brand);
        vehicleToUpdate.Stats().Log();
        "enter new caracteristics:".Log();
        var updatedVehicle = EnterVehicleProperties(vehicleToUpdate);
        ListVehicles
            .First(vehicle => vehicle.Brand == brand)
            .UpdateVehicle(updatedVehicle.Brand,updatedVehicle.Model, updatedVehicle.Year, updatedVehicle.Weight);
    }

    internal static void UpdateVehicle(this Vehicle vehicle, string brand, string model, int year, double weight)
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
            $"{vehicle}".Log();
        }
    }

    internal static void DisplayListOfSystemError()
    {
        List<SystemError> errorList = new List<SystemError>
        {
            new TransmissionError(),
            new EngineFailureError(),
            new BrakeFailureError()
        };
        foreach (SystemError error in errorList)
        {
            error.ErrorMessage().Log();
        }
        Console.WriteLine();
    }

    private static Vehicle EnterVehicleProperties(this Vehicle vehicle)
    {
        "Enter model:".Log();
        vehicle.Model = Console.ReadLine();
        "Enter year:".Log();
        vehicle.Year = Util.intValidation(Console.ReadLine());
        "Enter weight:".Log();
        vehicle.Weight = Util.DoubleValidation(Console.ReadLine());
        return vehicle;
    }
}