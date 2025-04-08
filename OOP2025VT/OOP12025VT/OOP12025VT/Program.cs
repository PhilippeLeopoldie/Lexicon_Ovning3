namespace OOP12025VT;

internal class Program
{
    static void Main(string[] args)
    {

        //Animal animal = new Animal(10.0);
        Cat cat = new Cat();
        Dog dog = new Dog(10.0);

        /*List<Animal> animals = new List<Animal>();
        animals.Add(dog);
        animals.Add(cat);*/

        var animals = new List<Animal>{cat, dog};
        foreach (Animal animal in animals)
        {
            var lunch = new Dog(1);
            animal.Eat(lunch);
            Console.WriteLine(animal);
        }
        
    }
}
// camelCase
// PascalCase

abstract class Animal
{
    public double Weight { get; set; }

    public Animal(double weight)
    {
        Weight = weight;
        MakeSound();
    }
    public virtual void Eat(Animal lunch)
    {
        Weight += lunch.Weight;
    }

    public override string ToString()
    {
        return $"Weight: {Weight}";
    }

    public abstract void MakeSound();
    
}

class Cat: Animal
{
    public double PurrVolume { get; }
    public Cat() : base(4.5)
    {
        PurrVolume = Weight * 0.5;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override string ToString()
    {
        return $"{base.ToString()}, PurrVolume: {PurrVolume}";
    }
}

class Dog: Animal 
{
    public Dog(double weight) : base(weight)
    {

    }

    public override void Eat(Animal lunch)
    {
        Weight += lunch.Weight * 0.8;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woff!");
    }
}