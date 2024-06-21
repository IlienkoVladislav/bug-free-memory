using System;

public class ClothingProduct : Product
{
    public string Size { get; set; }

    public ClothingProduct(string name, decimal price, string size)
        : base(name, price)
    {
        Size = size;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Size: {Size}");
    }
}
