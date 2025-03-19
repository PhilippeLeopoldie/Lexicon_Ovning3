// See https://aka.ms/new-console-template for more information

namespace Variables;

class Variables
{
    public static void Main(string[] args)
    {
        Console.WriteLine("what is your name?");
        Console.WriteLine("Type your first name: ");
        string myFirstName;
        myFirstName= Console.ReadLine();

        string myLastName;
        Console.Write("Type your last name:");
        myLastName = Console.ReadLine();

        Console.WriteLine("Hello," + myFirstName + " " + myLastName);
        Console.ReadLine();
    }
}