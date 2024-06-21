using System;

public class Triangle : Shape, IDrawable
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Triangle with base {baseLength} and height {height}");
    }
}
