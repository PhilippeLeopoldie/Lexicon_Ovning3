namespace Option1_YouthOrSenior;

public class YouthOrSeniorStarter
{
    public Person person = new Person();
    public uint NumberOfPerson {  get; set; }
    public int TotalPrice { get; set; }

    public void Run()
    {
        Console.Write("Enter number of person: ");
        NumberOfPerson = YouthOrSeniorHelper.UintValidation(Console.ReadLine());
        for(int i = 1; i <= NumberOfPerson; i++)
        {
            Console.Write($"Enter person{i}'s name: ");
            person.Name = YouthOrSeniorHelper.StringValidation(Console.ReadLine());
            Console.Write($"Enter {person.Name}'s age in 'Year': ");
            person.Age = YouthOrSeniorHelper.UintValidation(Console.ReadLine());
            Console.Write($"{person.Name} has ");
            TotalPrice += YouthOrSeniorHelper.GetPrice(person);
        }
        Console.WriteLine($"Total price for {NumberOfPerson} person(s): {TotalPrice}kr");
    }
}