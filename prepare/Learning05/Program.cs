using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rc = new Rectangle("Black", 2, 4);
        string color = rc.GetColor();
        double area = rc.GetArea();
        Console.WriteLine($"\nTesting Rectangle Class:\n- color = {color}\n- area = {area}\n");
    }
}