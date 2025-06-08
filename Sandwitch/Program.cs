using System;

class Sandwich
{
    public string BreadType;
    public string Fillings;
    public string Sauce;
    public bool IsToasted = true;
    public string ExtraFill;

    public Sandwich(string breadType, string fillings, string sauce)
    {
        BreadType = breadType;
        Fillings = fillings;
        Sauce = sauce;
    }

    public void YourOrder()
    {
        Console.WriteLine("Your order:");
        Console.WriteLine($"{BreadType} sandwich with {Fillings} and with {Sauce} is ready.");
    }
}

class VegSandwich : Sandwich
{
    public VegSandwich(string breadType, string fillings, string sauce)
        : base(breadType, fillings, sauce)
    {
    }
}

class CSandwich : Sandwich
{
    public CSandwich(string breadType, string fillings, string sauce, string extraFill)
        : base(breadType, fillings, sauce)
    {
        ExtraFill = extraFill;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Which sandwich do you want to eat: Veg or Chicken sir?");
        string choice = Console.ReadLine();
        Console.WriteLine("Okay sir! :)");

        if (choice.ToLower() == "chicken")
        {
            CSandwich c1 = new CSandwich("Chicken", "sauce mayo tomato", "ketchup", "Chicken pattie");
            c1.YourOrder();
        }
        else if (choice.ToLower() == "veg")
        {
            VegSandwich v1 = new VegSandwich("Veg", "sauce mayo tomato", "ketchup");
            v1.YourOrder();
        }
        else
        {
            Console.WriteLine("Sorry, we only serve Veg or Chicken sandwiches.");
        }
    }
}