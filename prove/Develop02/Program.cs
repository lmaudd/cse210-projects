using System;

// File: Program.cs
//
// Program Purpose: Create a journal program to store write, store, save, and
// load entries. It intends to address usual problems with journal writing,
// such as convenience (digitizing it) and not knowing what to write (prompting).
//
// Above & Beyond: In my group, Kristen Lee and I discussed things we could do.
// One such idea was adding a pin. I honestly don't remember who said it first, 
// I really liked the idea, so I chose to implement it. A major concern when writing
// journal entries is vulnerability and privacy. Adding a pin to restrict access to
// your saved journal entries may provide the user with enough security to feel
// comfortable writing.

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
                journal.Load();
            }

            else if (userInput == "4") // Save to file
            {
                journal.Save();
            }

            else if (userInput == "5") // Quit Application
            {
                Console.Write("Thank you for using our application.");
                Console.Write(" ");
                break;
            }

            else // Catch bad inputs
            {
                Console.WriteLine(" ");
                Console.WriteLine("Input not recognized. Try again.");
                Console.Write(" ");
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