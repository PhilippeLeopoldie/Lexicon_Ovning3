using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option1_YouthOrSenior;

internal static class YouthOrSeniorHelper
{
    const int FreePrice = 0;
    const int YouthPrice = 80;
    const int SeniorPrice = 90;
    const int StandardPrice = 120;

    internal static uint UintValidation (string input)
    {
        uint result;
        while(!uint.TryParse(input, out result))
        {
            Console.Write("Invalid entry, try again: ");
            input = Console.ReadLine();
        };
        return result;
    }

    internal static string StringValidation (string input)
    {
        while (string.IsNullOrWhiteSpace(input))
        {
            
            Console.Write("Invalid entry, try again: ");
            input = Console.ReadLine();
        };
        return input;
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
