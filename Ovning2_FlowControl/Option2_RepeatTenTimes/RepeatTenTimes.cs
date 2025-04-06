namespace Option2_RepeatTenTimes;

public static class RepeatTenTimes
{
    public static void Run()
    {
        Console.WriteLine("------Repeat Ten Times------");
        int numberOfRepetition = 10;
        Console.Write("Enter your text: ");
        var input = Console.ReadLine();
        for (int i = 1; i <= numberOfRepetition; i++)
        {
            Console.Write($"{i}.{input}, ");
        }
    }
}