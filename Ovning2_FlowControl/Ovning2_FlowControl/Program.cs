namespace Ovning2_FlowControl;

internal class Program
{
    static void Main(string[] args)
    {
        var input="0";
        do
        {
            input = MainMenu.StartMainMenu();
            Helper.RunApp(input);
        }
        while (input != "0");
    }
}
