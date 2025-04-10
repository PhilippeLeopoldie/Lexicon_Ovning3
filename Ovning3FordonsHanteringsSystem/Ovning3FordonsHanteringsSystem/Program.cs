using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;
using Ovning3FordonsHanteringsSystem.Vehicles;


internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            VehicleHandler.CreateVehicle();
            VehicleHandler.DisplayVehicles();
            VehicleHandler.ModifyBrand();
            VehicleHandler.DisplayVehicles();
            List<SystemError> errorList = new List<SystemError>
            {
                new TransmissionError(),
                new EngineFailureError(),
                new BrakeFailureError()
            };

            foreach (SystemError error in errorList)
            {
                Util.Log(error.ErrorMessage());
            }

            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Car(),
                new Truck(),
                new Motorcycle(),
                new ElectricScooter(),
            };

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
