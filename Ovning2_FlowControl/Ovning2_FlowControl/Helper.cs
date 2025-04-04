using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Option1;


namespace Ovning2_FlowControl;

internal static class Helper
{
    /*internal static void AddOption(Dictionary<string,string> optionsList, string optionNumber, string optionName )
    {
        optionsList.Add( optionNumber, optionName );
    }*/
    
    internal static void RunApp(string input)
    {
        switch (input)
        {
            case "0":
                break;
            case "1": Option1Starter.Run();
                break;
            default: 
                Console.WriteLine("invalid entry");
                break;
        }
        Console.WriteLine();
    }
}
