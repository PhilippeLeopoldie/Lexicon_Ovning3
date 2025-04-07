using Option1_YouthOrSenior;
using Option2_RepeatTenTimes;
using Option3_TheThirdWord;


namespace Ovning2_FlowControl;

internal static class FlowControlHelper
{
    internal static string RunApp(string input)
    {
        switch (input)
        {
            case "0":
                break;
            case "1": new YouthOrSeniorMenu().Run();
                break;
            case "2": RepeatTenTimesMenu.Run();
                break;
            case "3": TheThirdWordMenu.Run();
                break;
            default: 
                Console.WriteLine("invalid entry");
                break;
        }
        Console.WriteLine();
        return input;
    }
}
