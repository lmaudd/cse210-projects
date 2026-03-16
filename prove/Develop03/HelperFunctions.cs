// https://stackoverflow.com/questions/8879774/how-can-i-check-if-a-string-contains-a-character-in-c
// https://stackoverflow.com/questions/748062/return-multiple-values-to-a-method-caller
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

using System;

class HelperFunctions
{
    // Class Methods ///////////////////////////////////////////////////
    public (string, string) Load()
    {
        // Prints
        Console.WriteLine(" ");
        Console.WriteLine("Loading...");

        // Add strings to lists
        List<string> text = new List<string>();
        List<string> reference = new List<string>();
        string[] lines = System.IO.File.ReadAllLines("StoredScriptures.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            text.Add(parts[1]);
            reference.Add(parts[0]);
        }

        // Prints
        Console.WriteLine("Loading succesful.");
        Console.WriteLine(" ");
        Console.WriteLine("Make selection... (type 1, 2, etc.)");

        int i = 1;
        foreach (string line in reference)
        {
            Console.WriteLine($"   ({i}) {line}");
            i++;
        }

        // Get user answer
        Console.WriteLine(" ");
        Console.Write("Choice... ");
        string userInput = Console.ReadLine();
        int index = Int32.Parse(userInput) - 1;

        // Finish
        Thread.Sleep(600); // Sleep for number/1000 sec
        Console.WriteLine($"Choice saved: {reference[index]}");
        Thread.Sleep(2000); // Sleep for number/1000 sec

        return (text[index], reference[index]);
    }

    public void Quit()
    {
        Thread.Sleep(500); // Sleep for number/1000 sec
        Console.WriteLine(" ");
        Console.WriteLine("Thank you for using!");
        Console.WriteLine(" ");
    }

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("| User Options Menu (type #)                |");
        Console.WriteLine("|   (1) Load scripture                      |");
        Console.WriteLine("|   (2) Hide word                           |");
        Console.WriteLine("|   (9) Quit application                    |");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(" ");
    }

    public int UserInquire()
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.Write("Type here: ");
        string input = Console.ReadLine();
        int inputInt = Int32.Parse(input);
        return inputInt;
    }
}