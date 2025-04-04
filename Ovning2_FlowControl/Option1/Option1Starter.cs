namespace Option1;

public static class Option1Starter
{
    public static void Run()
    {
        //Add filter: number of person then  for loop from 1 to number of person...
        Console.Write("Enter your age: ");// change to $"Enter person {i} age "
        var age = Option1Helper.AgeValidation(Console.ReadLine());
        Option1Helper.DisplayDiscount(age);
    }
}
