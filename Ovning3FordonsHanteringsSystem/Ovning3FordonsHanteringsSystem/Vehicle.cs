﻿namespace Ovning3FordonsHanteringsSystem;

internal class Vehicle
{
    private string brand;
    private string model;
    private int year;
    private double weight;

    private const int minYear = 1886;
    private int maxYear = DateTime.Now.Year;
    private const string charactersErrorMsg = "Number of character must be > 2 and < 20:";

    public string Brand
    {
        get => brand;
        set
        {
            if (HasValidNumberOfCharacters(value))
                brand = value;
            else Log(charactersErrorMsg);
        }
    }
    
    public string Model
    {
        get => model;
        set
        {
            if (HasValidNumberOfCharacters(value))
                model = value;
            else Log(charactersErrorMsg);
        }
    }

    public int Year
    {
        get => year;
        set
        {
            if (HasValidYear(value))
                year = value;
            else Log($"year must be between {minYear} and {maxYear}");
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if (isPositive(value))
                weight = value;
            else Log("Only positive values accepted");
        }
    }

    private bool HasValidNumberOfCharacters(string str)
    {
        return str.Length >= 2 && str.Length <= 20; 
    }

    private bool HasValidYear(int year)
    {
        return year > 1886 && year <= DateTime.Now.Year;
    }

    private void Log(string msg)
    {
        throw new ArgumentException($"{msg}");
    }

    private bool isPositive(double value)
    {
        return value >= 0;
    }
}
