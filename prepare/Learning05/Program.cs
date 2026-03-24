using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Circle crc = new Circle("Pink", 1.59576912161);
        string color = crc.GetColor();
        double area = crc.GetArea();
        Console.WriteLine($"\nTesting Square Class:\n- color = {color}\n- area = {area}\n");
    }
}