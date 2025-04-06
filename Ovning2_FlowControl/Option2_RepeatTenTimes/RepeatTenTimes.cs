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
}