// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("The Name Game");

Console.Write("What's your first name?");
string firstName = Console.ReadLine();

Console.Write("What's your last name?");
string lastName = Console.ReadLine();

Console.Write("In what city are you born?");
string city = Console.ReadLine();

DisplayResult( ReverseString(firstName),
    ReverseString(lastName) ,
    ReverseString(city));



static string ReverseString(string message)
{
    char[] messageArray = message.ToCharArray();
    Array.Reverse(messageArray);
    return String.Concat(messageArray);
}

static void DisplayResult (string reversedFirstName, string reversedLastName, string reversedCity)
{
    Console.Write(String.Format("{0} {1} {2}",
    reversedFirstName,
    reversedLastName,
    reversedCity
    ));
}