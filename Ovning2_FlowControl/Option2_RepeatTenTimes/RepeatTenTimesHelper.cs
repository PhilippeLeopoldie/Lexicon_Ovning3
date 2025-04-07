namespace Option2_RepeatTenTimes
{
    internal class RepeatTenTimesHelper
    {
        internal static void DisplayPresentation()
        {
            Console.WriteLine("------Repeat Ten Times------");
            Console.Write("Enter your text: ");
        }

        internal static void DisplayNTime(string input, int numberOfRepetition)
        {
            for (int i = 1; i <= numberOfRepetition; i++)
            {
                Console.Write($"{i}. {input}");
                if (i < numberOfRepetition) Console.Write(", ");
            }
        }
    }
}
