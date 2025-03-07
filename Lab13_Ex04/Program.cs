using System;

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    private double _radius;
    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
                throw new ArgumentException("Radius cannot be negative.");
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width cannot be negative.");
            _width = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height cannot be negative.");
            _height = value;
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Shape shape1 = new Circle(5);
        Shape shape2 = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {shape1.Area()}");
        Console.WriteLine($"Rectangle Area: {shape2.Area()}");
    }
}
