using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option1;

internal static class Option1Helper
{
    const int YouthPrice = 80;
    const int SeniorPrice = 90;
    const int StandardPrice = 120;

    internal static uint AgeValidation (string input)
    {
        uint result;
        while(!uint.TryParse(input, out result) || result == 0)
        {
            Console.WriteLine("Invalid entry");
            Console.WriteLine("Enter your age:");
            input = Console.ReadLine();
        };
        return result;
    }

    internal static int DisplayDiscount(uint age)
    {
        int price;
        if(age < 20)
        {
            price = YouthPrice;
            Console.WriteLine($"Youth price: {YouthPrice}kr");
        } else if(age > 64)
        {
            price = SeniorPrice;
            Console.WriteLine($"Senior price: {SeniorPrice}kr");
        }
        else
        {
            price = StandardPrice;
            Console.WriteLine($"Standard price: {StandardPrice}kr");
        }
        return price;
    }

    
}
