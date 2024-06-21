using System;

public class Program
{
    public static void Main(string[] args)
    {
        DocumentFactory factory = new DocumentFactory();

        Document pdfDocument = factory.CreateDocument("pdf");
        Document wordDocument = factory.CreateDocument("word");
        Document excelDocument = factory.CreateDocument("excel");

        Console.WriteLine();
        pdfDocument.PrepareForPrinting();

        Console.WriteLine();
        wordDocument.PrepareForPrinting();

        Console.WriteLine();
        excelDocument.PrepareForPrinting();
    }
}
