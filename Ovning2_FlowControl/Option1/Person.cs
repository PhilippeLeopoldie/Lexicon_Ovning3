namespace Option1_YouthOrSenior;

internal class Person
{
    internal string Name { get; set; }
    internal uint Age { get; set; }
    internal PriceLevel PriceLevel {
        get
        {
            if (Age < 5 || Age > 100)
            {
                return PriceLevel.FreePrice;
            }
            else if (Age < 20)
            {
                return PriceLevel.YouthPrice;
            }
            else if (Age > 64)
            {
                return PriceLevel.SeniorPrice;
            }
            else
            {
                return PriceLevel.StandardPrice;
            }
        }
    }
}