using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                Console.WriteLine("Choose the product type: (1) CatFood or (2) DogLeash");
                string productTypeInput = Console.ReadLine();

                if (productTypeInput == "1")
                {
                    Console.WriteLine("Enter the name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the price:");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the description:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter the weight in pounds:");
                    double weightPounds = double.Parse(Console.ReadLine());

                    Console.WriteLine("Is it kitten food? (true/false):");
                    bool kittenFood = bool.Parse(Console.ReadLine());

                    CatFood catFood = new CatFood
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity,
                        Description = description,
                        WeightPounds = weightPounds,
                        KittenFood = kittenFood
                    };

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
                else if (productTypeInput == "2")
                {
                    Console.WriteLine("Enter the name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the price:");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the description:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter the length in inches:");
                    int lengthInches = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the material:");
                    string material = Console.ReadLine();

                    DogLeash dogLeash = new DogLeash
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity,
                        Description = description,
                        LengthInches = lengthInches,
                        Material = material
                    };

                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
}

class CatFood : Product
{
    public double WeightPounds { get; set; }
    public bool KittenFood { get; set; }
}

class DogLeash : Product
{
    public int LengthInches { get; set; }
    public string Material { get; set; }
}
