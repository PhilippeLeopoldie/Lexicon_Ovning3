namespace Option2_RepeatTenTimes;

public static class RepeatTenTimes
{
    const int numberOfRepetition = 10;
    public static void Run()
    {
        Console.WriteLine("------Repeat Ten Times------");
        Console.Write("Enter your text: ");
        var input = Console.ReadLine();
        for (int i = 1; i <= numberOfRepetition; i++)
        {
            Console.Write($"{i}.{input}, ");
        }
    }
}