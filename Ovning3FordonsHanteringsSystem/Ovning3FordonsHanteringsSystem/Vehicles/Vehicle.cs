namespace Ovning3FordonsHanteringsSystem.Vehicles;

public abstract class Vehicle
{
    private string brand;
    private string model;
    private int year;
    private double weight;

    private const int minYear = 1886;
    private int maxYear = DateTime.Now.Year;
    private const string charactersErrorMsg = "Number of character must be > 2 and < 20.";
    private const string unknownValue = "unknown";

    public Vehicle(string brand = unknownValue, string model = unknownValue, int year = minYear, double weight = 0 )
    {
        Brand = brand;
        Model = model;
        Year = year;
        Weight = weight;
    }
    
    public string Brand
    {
        get => brand;
        set
        {
            brand = Util.StringValidation(value, charactersErrorMsg);
        }
    }
    public string Model
    {
        get => model;
        set
        {
            model = Util.StringValidation(value, charactersErrorMsg);
        }
    }

    public int Year
    {
        get => year;
        set
        {
            year = YearValidation(value);
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
           weight = WeightValidation(value);
        }
    }

    public abstract string StartEngine();
    public abstract string Stats();

    private int YearValidation(int year)
    {
        while (!HasValidYear(year))
        {
            Util.ErrorMsg($"year must be between {minYear} and {maxYear}: ");
            Util.Log("Try again:");
            var result = Console.ReadLine();
            year = Util.intValidation(result);
        }
        return year;
    }

    private double WeightValidation(double weight)
    {
        while(weight < 0 )
        {
            Util.ErrorMsg("Only positive values accepted");
            Util.Log("Try again:");
            var result = Console.ReadLine();
            weight = Util.DoubleValidation(result);
        }
        return weight;
    }

    private bool HasValidYear(int year)
    {
        return year >= minYear && year <= DateTime.Now.Year;
    }

    public override string ToString()
    {
        return $"Vehicle brand: {Brand}, model: {Model}, year: {Year}, weight: {Weight}";
    }
}

