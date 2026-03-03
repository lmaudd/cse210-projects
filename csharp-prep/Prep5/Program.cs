using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numSquared = SquareNumber(number);
        int birthYear = PromtUserBirthYear();
        int userAge = UserAge(birthYear);
        WriteToConsole(name, numSquared, userAge);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int favoriteNumberInt = int.Parse(favoriteNumber);
        return favoriteNumberInt;
    }

    static int PromtUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string dateOfBirth = Console.ReadLine();
        int dateOfBirthInt = int.Parse(dateOfBirth);
        return dateOfBirthInt;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static int UserAge(int birthYear)
    {
        int ageThisYear = 2026 - birthYear;
        return ageThisYear;
    }

    static void WriteToConsole(string name, int numSquared, int userAge)
    {
        Console.WriteLine($"{name}, the square of your number is {numSquared}.");
        Console.WriteLine($"{name}, you will turn {userAge} this year.");
        Console.WriteLine(" ");
    }
}