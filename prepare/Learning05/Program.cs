using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("blue", 2.0);
        string color = sq.GetColor();
        double area = sq.GetArea();
        Console.WriteLine($"\nTesting Square Class:\n- color = {color}\n- area = {area}\n");
    }
}