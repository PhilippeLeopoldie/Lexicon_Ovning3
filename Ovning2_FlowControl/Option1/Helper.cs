namespace Option1_YouthOrSenior;

internal static class Helper
{
    const int FreePrice = 0;
    const int YouthPrice = 80;
    const int SeniorPrice = 90;
    const int StandardPrice = 120;



    internal static void DisplayPresentation()
    {
        Console.WriteLine("------Cinema Tickets------");
        Console.Write("Enter number of person: ");
    }


    internal static int GetPrice(Person person)
    {
        var currentPriceLevel= person.PriceLevel;
        int price;
        if(currentPriceLevel == PriceLevel.FreePrice)
        {
            price = FreePrice;
            Console.WriteLine($"{person.Name} has an Entry for Free: {FreePrice}kr");
        }
        else if (currentPriceLevel == PriceLevel.YouthPrice)
        {
            price = YouthPrice;
            Console.WriteLine($"{person.Name} has a Youth price: {YouthPrice}kr");
        }
        else if (currentPriceLevel == PriceLevel.SeniorPrice)
        {
            price = SeniorPrice;
            Console.WriteLine($"{person.Name} has a Senior price: {SeniorPrice}kr");
        }
        else
        {
            price = StandardPrice;
            Console.WriteLine($"{person.Name} has a Standard price: {StandardPrice}kr");
        }
        return price;
    }

    

    
}
