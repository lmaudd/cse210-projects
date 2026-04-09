// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Running
        string date = "03 Nov 2022";
        float length = 30.0F;
        float distance = 3.0F;
        Running running = new Running(date, length, distance);
        string summary = running.GetSummary();
        Console.WriteLine(summary);

        // Instantiate Biking


        // Instantiate Swimming


    }
}