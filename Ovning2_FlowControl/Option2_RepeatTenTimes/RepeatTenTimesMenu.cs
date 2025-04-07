using Option1_YouthOrSenior;
namespace Option2_RepeatTenTimes;

public static class RepeatTenTimesMenu
{
    private const int numberOfRepetition = 10;
    public static void Run()
    {
        RepeatTenTimesHelper.DisplayPresentation();
        var input = Util.StringValidation(Console.ReadLine());
        RepeatTenTimesHelper.DisplayNTime(input,numberOfRepetition);
        Console.WriteLine();
    }
}