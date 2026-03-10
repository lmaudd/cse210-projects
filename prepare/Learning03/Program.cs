using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Fraction Class – Verified output 
        Fraction fraction = new Fraction();
        int top = fraction.GetTop();
        int bottom = fraction.GetBottom();
        string fractionString = fraction.GetFractionString();
        double fractionDecimal = fraction.GetDecimalValue();
        Console.WriteLine($"top = 1 = {top}.");
        Console.WriteLine($"bottom = 1 = {bottom}.");
        Console.WriteLine($"fractionString = 1/1 = {fractionString}.");
        Console.WriteLine($"fractionDecimal = 1. = {fractionDecimal}.");

        // Instantiate Fraction Class – Verified output 
        Fraction fraction2 = new Fraction(7);
        int top2 = fraction2.GetTop();
        int bottom2 = fraction2.GetBottom();
        string fractionString2 = fraction2.GetFractionString();
        double fractionDecimal2 = fraction2.GetDecimalValue();
        Console.WriteLine($"top2 = 7 = {top2}.");
        Console.WriteLine($"bottom2 = 1 = {bottom2}.");
        Console.WriteLine($"fractionString2 = 7/1 = {fractionString2}.");
        Console.WriteLine($"fractionDecimal2 = 7. = {fractionDecimal2}.");

        // Instantiate Fraction Class – FAILED output 
        Fraction fraction3 = new Fraction(1,3);
        int top3 = fraction3.GetTop();
        int bottom3 = fraction3.GetBottom();
        string fractionString3 = fraction3.GetFractionString();
        double fractionDecimal3 = fraction3.GetDecimalValue();
        Console.WriteLine($"top3 = 1 = {top3}.");
        Console.WriteLine($"bottom3 = 3 = {bottom3}.");
        Console.WriteLine($"fractionString3 = 1/3 = {fractionString3}.");
        Console.WriteLine($"fractionDecimal3 = 0.3333333 = {fractionDecimal3}.");
    }
}