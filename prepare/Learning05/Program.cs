using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle("Black", 2, 4) );
        shapes.Add(new Square("Pink", 3));
        shapes.Add(new Circle("Blue", 5));
        shapes.Add(new Rectangle("Black", 1, 2));
        shapes.Add(new Square("Yellow", 2));
        shapes.Add(new Circle("Green", 10));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color={color},  Area={area}");
        }
    }
}