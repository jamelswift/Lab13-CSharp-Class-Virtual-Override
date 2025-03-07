using System;

public abstract class Shape
{
    public abstract double Area();
    public abstract void Draw();
    public override string ToString() => GetType().Name;  // แสดงชื่อของชนิด (Class) เช่น Circle, Rectangle
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
    }
}

public class ShapeProcessor
{
    public void DisplayShapeInfo(Shape shape)
    {
        Console.WriteLine($"Area of {shape}: {shape.Area()}");
        shape.Draw();
    }
}

class Program
{
    static void Main()
    {
        ShapeProcessor processor = new ShapeProcessor();

        Circle circle = new Circle(5); 
        processor.DisplayShapeInfo(circle);

        Rectangle rectangle = new Rectangle(4, 6);
        processor.DisplayShapeInfo(rectangle);
    }
}
