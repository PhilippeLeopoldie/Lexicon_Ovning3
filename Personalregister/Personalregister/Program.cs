
using Personalregister;

/*Uppgift 1
 * Vilka klasser bör ingå i programmet? Personal*/  


/*Uppgift 2
 * Vilka attribut  och metoder bör ingå i dessa klasser? 
 * - attribut : PersonNummer, Fornamn, Efternamn, Lön
 * - metodes: Registration, displayPersonal, DisplayListPersonal
 */


/*Uppgift 3 */

string displayRegistration = "Y";

var personalList = new HashSet<Personal>();

while (displayRegistration == "Y")
{
    Registration();
}

DisplayListPersonal(personalList);

string Registration()
{
    Personal registration = new Personal();

    Console.WriteLine("PersonNummer:");
    registration.PersonNummer = Console.ReadLine();

    Console.WriteLine("Förnamn:");
    registration.Fornamn = Console.ReadLine();

    Console.WriteLine("Efternamn:");
    registration.Efternamn = Console.ReadLine();

    Console.WriteLine("Lön/Manader:");
    string lonInput = Console.ReadLine();
    decimal lon;
    while (!decimal.TryParse(lonInput, out lon))
    {
        Console.WriteLine("invalid lön. try again: ");
        lonInput = Console.ReadLine();
    }

    registration.Lon = lon;

    Console.WriteLine("Would you like to add a new personal?: Yes [Y]/No [N]");
    displayRegistration = Console.ReadLine().ToUpper();

    while(displayRegistration != "Y" &&  displayRegistration != "N")
    {
        Console.WriteLine("invalid answer. try again.");
        Console.WriteLine("Would you like to add a new personal?: Yes [Y]/No [N]");
        displayRegistration = Console.ReadLine().ToUpper();
    }
    personalList.Add(registration);
    return displayRegistration;
    
}

void displayPersonal(Personal personal)
{
    Console.WriteLine($"{personal.PersonNummer}, {personal.Fornamn} {personal.Efternamn}, {personal.Lon}kr");
}

void DisplayListPersonal( HashSet<Personal> personalList )
{
    foreach(var person in personalList)
    {
        displayPersonal(person);
    }
}







