using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5.0),
            new Square(4.0),
            new Triangle(3.0, 6.0)
        };

        foreach (var shape in shapes)
        {
            double area = shape.CalculateArea();
            Console.WriteLine($"Area of shape: {area}");

            if (shape is IDrawable drawableShape)
            {
                drawableShape.Draw();
            }

            Console.WriteLine();
        }
    }
}
