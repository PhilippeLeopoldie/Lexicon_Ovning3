namespace Option3_TheThirdWord;

internal class Helper
{
    internal static string[] RemoveEmptySpace(string input)
    {
        return input.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }

    internal static void DisplayPresentation()
    {
        Console.WriteLine("-------Third Word Extractor-------");
        Console.WriteLine("Enter a sentence of at least 3 words:");
    }
}
