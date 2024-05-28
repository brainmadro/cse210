using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> {
            new Circle("Red", 2),
            new Rectangle("Green", 3, 4),
            new Square("Blue", 5)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The shape has an area of {shape.GetArea()} and is color {shape.GetColor()}.");
        }

    }
}