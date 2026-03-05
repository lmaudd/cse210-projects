using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Journal Instance
        Journal journal = new Journal();

        // Program Loop
        Console.WriteLine("Welcome to the journal application!");

        while (true)
        {
            PrintMenu();
            string userInput = Console.ReadLine();

            if (userInput == "1") // Write journal entry
            {
                journal.GetEntry();
            }

            else if (userInput == "2") // Display all journals
            {
                journal.DisplayAll();
            }

            else if (userInput == "3") // Load from file
            {
                Console.Write("Unfinished.");
            }

            else if (userInput == "4") // Save to file
            {
                journal.Save();
            }

            else if (userInput == "5") // Quit Application
            {
                Console.Write("Thank you for using our application.");
                break;
            }

            else
            {
                Console.Write("Unfinished.");
            }
        }
    }

    static void PrintMenu()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Please Select an Option");
        Console.WriteLine("   1. Write");
        Console.WriteLine("   2. Display");
        Console.WriteLine("   3. Load");
        Console.WriteLine("   4. Save");
        Console.WriteLine("   5. Quit");
        Console.WriteLine(" ");
    }
}