using System;
using System.Collections.Generic;

public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(),
            new Rectangle(),
            new Circle(),
            new Triangle()
        };

        Console.WriteLine("Drawing Shapes:");
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
