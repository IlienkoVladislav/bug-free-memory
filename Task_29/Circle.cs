using System;

public class Circle : Shape, IDrawable
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Circle with radius {radius}");
    }
}
