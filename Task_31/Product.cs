using System;

public class Product
{
    private static int totalProducts = 0;

    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        totalProducts++;
    }

    public static int GetTotalProducts()
    {
        return totalProducts;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price:C}");
        Console.WriteLine($"Total Products Created: {totalProducts}");
    }
}
