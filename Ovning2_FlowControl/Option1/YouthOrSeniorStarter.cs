namespace Option1;

public static class YouthOrSeniorStarter
{
    public static void Run()
    {
        int totalPrice = 0;
        Console.Write("Enter number of person: ");
        var numberOfPerson = YouthOrSeniorHelper.UintValidation(Console.ReadLine());
        for(int i = 1; i <= numberOfPerson; i++)
        {
            Console.Write($"Enter person {i} age: ");
            var age = YouthOrSeniorHelper.UintValidation(Console.ReadLine());
            Console.Write($"Person {i} has ");
            totalPrice += YouthOrSeniorHelper.DisplayDiscount(age);
        }
        Console.WriteLine($"Total price for {numberOfPerson} person(s): {totalPrice}kr");
    }
}
