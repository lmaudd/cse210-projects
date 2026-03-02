using System;

class Program
{
    static void Main(string[] args)
    {   
        // Obtain First Name from user
        Console.WriteLine(" ");
        Console.WriteLine("What is your first name?");
        string nameFirst = Console.ReadLine();

        // Obtain Last Name from user
        Console.WriteLine(" ");
        Console.WriteLine("What is your last name?");
        string nameLast = Console.ReadLine();

        // Print User Name
        // note that I found a guide for string interpolation at:
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        Console.WriteLine(" ");
        string printSentence = $"Your name is {nameLast}, {nameFirst} {nameLast}.";
        Console.WriteLine(printSentence);
        Console.WriteLine(" ");
    }
}