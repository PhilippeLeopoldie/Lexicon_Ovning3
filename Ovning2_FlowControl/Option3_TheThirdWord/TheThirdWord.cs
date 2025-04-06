namespace Option3_TheThirdWord;

public static class TheThirdWord
{
    public static void Run()
    {
        var isValid = false;
        DisplayPresentation();
        do
        {
            var output = RemoveEmptySpace(Console.ReadLine());
            if (output.Count() >= 3)
            {
                isValid = true;
                Console.WriteLine($"The third word is: {output[2]}");
            } 
            else 
            { 
                Console.WriteLine("Invalid entry, try again: "); 
            }
        }
        while (!isValid);
    }

    private static string[] RemoveEmptySpace (string input)
    {
        return input.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }

    private static void DisplayPresentation()
    {
        Console.WriteLine("-------Third Word Extractor-------");
        Console.WriteLine("Enter a sentence of at least 3 words:");
    }
}