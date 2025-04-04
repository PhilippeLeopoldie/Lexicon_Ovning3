namespace Option1;

public static class Option1Starter
{
    public static void Run()
    {
        Console.Write("Enter number of person: ");
        var numberOfPerson = Option1Helper.UintValidation(Console.ReadLine());
        for(int i = 1; i <= numberOfPerson; i++)
        {
            Console.Write($"Enter person {i} age: ");
            var age = Option1Helper.UintValidation(Console.ReadLine());
            Console.Write($"Person {i} has a ");
            Option1Helper.DisplayDiscount(age);
        }
        
    }
}
