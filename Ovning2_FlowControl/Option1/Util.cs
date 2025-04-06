namespace Option1_YouthOrSenior;

public class Util
{
    public static uint UintValidation(string input)
    {
        uint result;
        while (!uint.TryParse(input, out result))
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
}
