using System;

class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }
}

class Animal : LivingOrganism, IReproducible, IPredator
{
    public int NumberOfLegs { get; set; }
    public void Reproduce()
    {
        Console.WriteLine("Тварина розмножується.");
    }

    public void Hunt(LivingOrganism prey)
    {
        Console.WriteLine("Тварина полює на інших організмів.");
    }
}

class Plant : LivingOrganism, IReproducible
{
    public string Type { get; set; }
    public void Reproduce()
    {
        Console.WriteLine("Рослина розмножується.");
    }
}

class Microorganism : LivingOrganism, IReproducible
{
    public string Species { get; set; }
    public void Reproduce()
    {
        Console.WriteLine("Мікроорганізм розмножується.");
    }
}

interface IReproducible
{
    void Reproduce();
}
interface IPredator
{
    void Hunt(LivingOrganism prey);
}

class Ecosystem
{
    public void SimulateInteraction(LivingOrganism organism1, LivingOrganism organism2)
    {
        Console.WriteLine("Взаємодія між організмами в екосистемі.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal lion = new Animal { Energy = 100, Age = 5, Size = 2, NumberOfLegs = 4 };
        Animal zebra = new Animal { Energy = 50, Age = 3, Size = 1.5, NumberOfLegs = 4 };

        Plant oak = new Plant { Energy = 10, Age = 10, Size = 5, Type = "Дуб" };

        ecosystem.SimulateInteraction(lion, zebra);
        ecosystem.SimulateInteraction(lion, oak);
    }
}