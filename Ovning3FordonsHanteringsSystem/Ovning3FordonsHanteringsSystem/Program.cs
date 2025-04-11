using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;
using Ovning3FordonsHanteringsSystem.Vehicles;



internal class Program
{
    /*  F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle? 
        Jag får ett kompileringsfel eftersom en lista av typen 'Motorcycle' inte 
        kan innehålla objekt av typen 'Car', typen matchar inte. 
      
       
     *  F: Vilken typ bör en lista vara för att rymma alla fordonstyper? 
        Listan måste vara av typen 'vehicle' för att kunna rymma alla fordonstyper som äver från 'Vehicle'.


     *  F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? 
        Nej, eftersom 'Vehicle' inte implementerar ICleanable, daför man måste först
        kontrolerra om dett fordon implementerar interfacet.


     *  F: Vad är fördelarna med att använda ett interface här istället för arv? 
        Man kan implementera flera interfaces, medan man barra kan  arv från en basklass
     */


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
