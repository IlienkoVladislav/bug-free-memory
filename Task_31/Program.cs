using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("Book", 15.99m));
        products.Add(new ElectronicProduct("Laptop", 999.99m, 12));
        products.Add(new ClothingProduct("T-Shirt", 19.99m, "M"));

        foreach (var product in products)
        {
            Console.WriteLine();
            product.DisplayInfo();
        }

        Console.WriteLine();
        Console.WriteLine($"Total Products Created: {Product.GetTotalProducts()}");
    }
}
