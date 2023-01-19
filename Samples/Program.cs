using Samples;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Products products1 = new Products 
        {
            Id= 1,
            Name= "Blender",
            UnitPrice = 300,
            UnitStock= 10,
        
        };
        Products products2 = new Products
        {
            Id = 2,
            Name = "AirFryer",
            UnitPrice = 4000,
            UnitStock = 50,

        };
        Products products3 = new Products
        {
            Id = 3,
            Name = "Hair Dryer",
            UnitPrice = 600,
            UnitStock = 87,

        };

        Products[] products = new Products[] 
        {
            products1,
            products2, 
            products3
        };

        foreach (var product in products)
        {
            Console.WriteLine(product.Id+" "+product.Name+" "+product.UnitPrice+" "+product.UnitStock);
        }
        Console.WriteLine();
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine(products1.Id + " " + products1.Name + " " + products1.UnitPrice + " " + products1.UnitStock);
            Console.WriteLine(products2.Id + " " + products2.Name + " " + products2.UnitPrice + " " + products2.UnitStock);
            Console.WriteLine(products3.Id + " " + products3.Name + " " + products3.UnitPrice + " " + products3.UnitStock);
        }
        Console.WriteLine();
        int j = 0;
        while (j<1)
        {
            Console.WriteLine(products1.Id + " " + products1.Name + " " + products1.UnitPrice + " " + products1.UnitStock);
            Console.WriteLine(products2.Id + " " + products2.Name + " " + products2.UnitPrice + " " + products2.UnitStock);
            Console.WriteLine(products3.Id + " " + products3.Name + " " + products3.UnitPrice + " " + products3.UnitStock);
            j++;
        }
    }
}