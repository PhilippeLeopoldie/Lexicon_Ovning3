using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;
using Ovning3FordonsHanteringsSystem.Vehicles;


internal class Program
{
    static void Main(string[] args)
    {
       
        try
        {
            VehicleHandler.CreateVehicle(new Car("Peugot", "3008", 2012, 1208, 24));
            VehicleHandler.CreateVehicle(new Motorcycle("Yamaha", "Model Yamaha", 2024, 500, true ));
            VehicleHandler.CreateVehicle(new Truck("Scania","r500", 2018, 8000, 3000));
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


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
