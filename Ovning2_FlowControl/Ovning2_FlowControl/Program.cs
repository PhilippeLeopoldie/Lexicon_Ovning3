namespace Ovning2_FlowControl;

internal class Program
{
    static void Main(string[] args)
    {
        MainMenu.ShowMainMenu();

        var input = Console.ReadLine();
        while (input  != "0")
        {
            Helper.RunApp(input);
            input = Console.ReadLine();
        }
    }
}
