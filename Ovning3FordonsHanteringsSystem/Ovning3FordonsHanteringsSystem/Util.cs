namespace Ovning3FordonsHanteringsSystem;

public static class Util
{
    public static int intValidation(string input)
    {
        int result;
        
        while (!int.TryParse(input, out result) || result<=0)
        {
            Console.Write("Invalid entry, try again: ");
            input = Console.ReadLine();
        };
        return result;
    }

    public static string StringValidation(string input)
    {
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("Invalid entry, try again: ");
            input = Console.ReadLine();
        };
        return input;
    }

    public static double DoubleValidation(string input)
    {
        double result;
        while (!double.TryParse(input, out result))
        {
            Console.WriteLine("Invalid entry, try again: ");
            input = Console.ReadLine();
        }
        return result;
    }
}
