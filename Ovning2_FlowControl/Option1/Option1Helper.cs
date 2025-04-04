using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option1;

internal static class Option1Helper
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

    internal static int DisplayDiscount(uint age)
    {
        int price;
        if(age < 5 || age > 100)
        {
            price = FreePrice;
            Console.WriteLine($"an Entry for Free: {FreePrice}kr");
        }
        else if (age < 20)
        {
            price = YouthPrice;
            Console.WriteLine($"a Youth price: {YouthPrice}kr");
        }
        else if (age > 64)
        {
            price = SeniorPrice;
            Console.WriteLine($"a Senior price: {SeniorPrice}kr");
        }
        else
        {
            price = StandardPrice;
            Console.WriteLine($"a Standard price: {StandardPrice}kr");
        }
        return price;

    }

    
}
