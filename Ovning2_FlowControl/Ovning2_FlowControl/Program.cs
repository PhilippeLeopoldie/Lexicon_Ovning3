namespace Ovning2_FlowControl;

internal class Program
{
    static void Main(string[] args)
    {
        var stopProgram = "0";
        var input="";
        do
        {
            input = Helper.RunApp(MainMenu.StartPresentation());
        }
        while (input != stopProgram);
    }
}
