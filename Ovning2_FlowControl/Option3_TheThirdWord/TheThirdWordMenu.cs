using Option1_YouthOrSenior;
namespace Option3_TheThirdWord;

public static class TheThirdWordMenu
{
    public static void Run()
    {
        var isValid = false;
        TheThirdWordHelper.DisplayPresentation();
        do
        {
            var input = Util.StringValidation(Console.ReadLine());
            var output = TheThirdWordHelper.RemoveEmptySpace(input);
            if (output.Count() >= 3)
            {
                isValid = true;
                Console.WriteLine($"The third word is: {output[2]}");
            } 
            else 
            { 
                Console.WriteLine("Please enter at least 3 words."); 
            }
        }
        while (!isValid);
    }
}