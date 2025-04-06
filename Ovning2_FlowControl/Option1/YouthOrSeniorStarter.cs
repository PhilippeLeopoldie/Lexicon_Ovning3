namespace Option1_YouthOrSenior;

public class YouthOrSeniorStarter : Person
{
    public uint NumberOfPerson {  get; set; }
    public int TotalPrice { get; set; }

    public void Run()
    {
        Console.Write("Enter number of person: ");
        NumberOfPerson = YouthOrSeniorHelper.UintValidation(Console.ReadLine());
        for(int i = 1; i <= NumberOfPerson; i++)
        {
            Console.Write($"Enter person{i}'s name: ");
            Name = YouthOrSeniorHelper.StringValidation(Console.ReadLine());
            Console.Write($"Enter {Name}'s age in 'Year': ");
            Age = YouthOrSeniorHelper.UintValidation(Console.ReadLine());
            Console.Write($"{Name} has ");
            TotalPrice += YouthOrSeniorHelper.DisplayDiscount(Age);
        }
        Console.WriteLine($"Total price for {NumberOfPerson} person(s): {TotalPrice}kr");
    }
}
