namespace Ovning3FordonsHanteringsSystem;

public static class Util
{
    public static int intValidation(this string input)
    {
        int result;
        while (!int.TryParse(input, out result) || result<=0)
        {
            Log("This is not a number, try again: ");
            input = Console.ReadLine();
        };
        return result;
    }

    public static string StringValidation( string input,  string errorMessage)
    {
        while (input.Length < 2 || input.Length > 20)
        {
            ErrorMsg(errorMessage);
            Log("Try again: ");
            input = Console.ReadLine();
        }
        return input.ToLower();
    }

    public static double DoubleValidation(this string input)
    {
        double result;
        while (!double.TryParse(input, out result))
        {
            Log("Invalid entry, try again: ");
            input = Console.ReadLine();
        }
        return result;
    }

    public static void Log(this string message)
    {
        Console.WriteLine(message);
    }

    public static void ErrorMsg(this string msg)
    {
        Log($"{new ArgumentException($"{msg}")}");
    }

    public static void NewLine()
    {
        Console.WriteLine();
    }
}
