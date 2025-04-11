using Ovning3FordonsHanteringsSystem.Vehicles;

namespace Ovning3FordonsHanteringsSystem;

internal class MainMenu
{
    private static Dictionary<int, string> Menu = new Dictionary<int, string>
    {
        {1,"Play Demo" },
        {2,"Enter a new car" },
        {3,"Update vehicle by brand" },
        {4,"Display List of vehicle" },
        {5,"Display list of system error" },
        {0,"Exit" }
    };

    internal static string StartPresentation()
    {
        "------- Main Menu -------".Log();
        "Choose a function :".Log();

        foreach (var option in Menu)
        {
            $"Enter {option.Key} for {option.Value}".Log();
        }
        return Console.ReadLine();
    }

    internal static void Run(int input)
    {
        switch (input)
        {
            case 1:
                Demo.Run();
                break;
            case 2:
                new Car().EnterNewVehicle().CreateVehicle();
                break;
            case 3:
                VehicleHandler.UpdateVehicleByBrand();
                break;
            case 4:
                VehicleHandler.DisplayVehicles();
                break;
            case 5:
               VehicleHandler.DisplayListOfSystemError();
                break;
            
            default:
                break;
        }
        
    }
}
