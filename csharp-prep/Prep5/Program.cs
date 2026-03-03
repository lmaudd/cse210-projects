using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtain user input
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();

        Console.Write("Please enter the year you were born: ");
        string dateOfBirth = Console.ReadLine();

        // Calculations
        int favoriteNumberInt = int.Parse(favoriteNumber);
        int numSquared = favoriteNumberInt * favoriteNumberInt;

        int dateOfBirthInt = int.Parse(dateOfBirth);
        int aegThisYear = 2026 - dateOfBirthInt;

        // Write to console
        Console.WriteLine($"{name}, the square of your number is {numSquared}.");
        Console.WriteLine($"{name}, you will turn {aegThisYear} this year.");
        Console.WriteLine(" ");

    }
}