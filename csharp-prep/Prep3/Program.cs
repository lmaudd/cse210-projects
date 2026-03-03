using System;

class Program
{
    static void Main(string[] args)
    {
        // Establish magic number
        Console.WriteLine(" ");
        Console.WriteLine("----------------------------------");
        Console.Write("What is your magic number? "); // Ask question
        string magicNumberInput = Console.ReadLine(); // Store answer as string
        int magicNumber = int.Parse(magicNumberInput); // Store number as int
        Console.WriteLine(" ");
        
        // Initialize loop condition
        bool cont = true;

        // Game Loop
        while (cont == true)
        {
            // Establish guess
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);

            // Victory condition
            if (guess == magicNumber)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Correct!");
                Console.WriteLine("----------------------------------");
                cont = false;
            }

            // Too high
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            // Too low
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}