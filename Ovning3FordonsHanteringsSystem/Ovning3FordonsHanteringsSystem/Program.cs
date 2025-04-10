namespace Ovning3FordonsHanteringsSystem;

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
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
