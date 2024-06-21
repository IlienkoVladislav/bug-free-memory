using System;

public abstract class Document
{
    public abstract void Print();

    public void PrepareForPrinting()
    {
        Console.WriteLine("Preparing document for printing...");
        Print();
        Console.WriteLine("Document preparation complete.");
    }
}
