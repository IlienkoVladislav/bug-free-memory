using System;

public class Square : Shape, IDrawable
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return sideLength * sideLength;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Square with side length {sideLength}");
    }
}
