using Option1_YouthOrSenior;
namespace Option2_RepeatTenTimes;

public static class RepeatTenTimes
{
    private const int numberOfRepetition = 10;
    public static void Run()
    {
        Helper.DisplayPresentation();
        var input = Util.StringValidation(Console.ReadLine());
        Helper.DisplayNTime(input,numberOfRepetition);
        Console.WriteLine();
    }

    /*private static void DisplayPresentation()
    {
        Console.WriteLine("------Repeat Ten Times------");
        Console.Write("Enter your text: ");
    }

    private static void DisplayNTime(string input,  int numberOfRepetition)
    {
        for (int i = 1; i <= numberOfRepetition; i++)
        {
            Console.Write($"{i}. {input}");
            if (i < numberOfRepetition) Console.Write(", ");
        }
    }*/
}