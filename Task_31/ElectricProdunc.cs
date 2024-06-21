using System;

public class ElectronicProduct : Product
{
    public int WarrantyPeriod { get; set; }

    public ElectronicProduct(string name, decimal price, int warrantyPeriod)
        : base(name, price)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Warranty Period: {WarrantyPeriod} months");
    }
}
