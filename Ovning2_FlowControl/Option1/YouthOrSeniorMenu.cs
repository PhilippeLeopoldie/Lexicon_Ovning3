namespace Option1_YouthOrSenior;

public class YouthOrSeniorMenu
{
    private Person person = new Person();
    private uint NumberOfPerson {  get; set; }
    private int TotalPrice { get; set; }

    public void Run()
    {
        YouthOrSeniorHelper.DisplayPresentation();
        NumberOfPerson = Util.UintValidation(Console.ReadLine());
        for(int i = 1; i <= NumberOfPerson; i++)
        {
            Console.Write($"Enter person{i}'s name: ");
            person.Name = Util.StringValidation(Console.ReadLine());
            Console.Write($"Enter {person.Name}'s age in 'Year': ");
            person.Age = Util.UintValidation(Console.ReadLine());
            TotalPrice += YouthOrSeniorHelper.GetPrice(person);
            Console.WriteLine();
        }
        Console.WriteLine($"Total price for {NumberOfPerson} person(s): {TotalPrice}kr");
    }
}