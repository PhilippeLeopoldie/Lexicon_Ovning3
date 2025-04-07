namespace Ovning2_FlowControl;

internal static class MainMenu
{
    private static Dictionary<string,string> Menu = new Dictionary<string, string>
    {
        {"1","Youth or Senior discount" },
        {"2","Repeat Ten Times" },
        {"3","Extract The Third Word" },
        {"0","Exit" }
    };
    
    internal static string StartPresentation()
    {
        Console.WriteLine("------- Main Menu -------");
        Console.WriteLine("Choose a function :");

        foreach (var option in Menu)
        {
            Console.WriteLine($"Enter {option.Key} for {option.Value}");
        }
        return Console.ReadLine();
    }

    
}
