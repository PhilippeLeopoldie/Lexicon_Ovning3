using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;


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
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
