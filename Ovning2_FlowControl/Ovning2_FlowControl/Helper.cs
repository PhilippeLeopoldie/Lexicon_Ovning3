using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Option1_YouthOrSenior;
using Option2_RepeatTenTimes;
using Option3_TheThirdWord;


namespace Ovning2_FlowControl;

internal static class Helper
{
    /*internal static void AddOption(Dictionary<string,string> optionsList, string optionNumber, string optionName )
    {
        optionsList.Add( optionNumber, optionName );
    }*/
    
    internal static string RunApp(string input)
    {
        switch (input)
        {
            case "0":
                break;
            case "1": new YouthOrSeniorStarter().Run();
                break;
            case "2": RepeatTenTimes.Run();
                break;
            case "3": TheThirdWord.Run();
                break;
            default: 
                Console.WriteLine("invalid entry");
                break;
        }
        Console.WriteLine();
        return input;
    }
}
