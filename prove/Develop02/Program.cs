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

            if (userInput == "1")
            {
                
            }

            else if (userInput == "2")
            {
                
            }

            else if (userInput == "3")
            {
                
            }

            else if (userInput == "4")
            {
                
            }

            else if (userInput == "5")
            {
                
            }

            else
            {

            }
        
        }

        journal.DisplayAll();
    }

    static void PrintMenu()
    {
        Console.Write("Please Select an Option");
        Console.Write("   1. Write");
        Console.Write("   2. Display");
        Console.Write("   3. Load");
        Console.Write("   4. Save");
        Console.Write("   5. Quit");
    }
}


            journal.GetEntry();

            Console.Write("Would you like to continue? (0=yes): ");
            loopCondition = Console.ReadLine();