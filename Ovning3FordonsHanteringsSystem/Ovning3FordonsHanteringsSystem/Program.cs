using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;
using Ovning3FordonsHanteringsSystem.Vehicles;



internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            "------Del 2 Display List of SystemError objects-------".Log();
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

            "-----Create 4 vehicles-------".Log();
            new Car("Peugot", "3008", 2012, 1208, 24).CreateVehicle();
            new Motorcycle("Yamaha", "Model Yamaha", 2024, 500, true ).CreateVehicle();
            new Truck("Scania", "r500", 2018, 8000, 3000).CreateVehicle();
            new ElectricScooter("Xiaomi", "m365", 2021, 12, 12.5).CreateVehicle();
            VehicleHandler.DisplayVehicles();
            Console.WriteLine();

            "-------modify the brand of the first vehicle----------".Log();
            VehicleHandler.ListVehicles.First().UpdateBrand("Volvo");
            VehicleHandler.DisplayVehicles();
            Console.WriteLine();

            "-------modify the vehicle 'xiamo'----------".Log();
            VehicleHandler.ListVehicles.First(vehicle => vehicle.Brand == "xiaomi").UpdateVehicle("segway", "Minebot Max", 2022, 19);
            VehicleHandler.DisplayVehicles();
            Console.WriteLine();

            "----Del4: loop throw list-------".Log();
            foreach(var vehicle in  VehicleHandler.ListVehicles)
            {
                vehicle.StartEngine().Log();
                $"{vehicle.Stats()}".Log();
                if(vehicle is ICleanable cleanable)
                {
                    cleanable.Clean().Log();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        catch (Exception e)
        {
            e.Message.Log();
        }
    }
}
