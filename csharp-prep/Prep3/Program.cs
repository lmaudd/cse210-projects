using System;

class Program
{
    static void Main(string[] args)
    {
        // Establish magic number
        Console.WriteLine(" ");
        Console.WriteLine("----------------------------------");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(11); // Random number between 0 and 10
        
        // Initialize loop condition
        bool cont = true;

        // Game Loop
        while (cont == true)
        {
            // Establish guess
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);

            // Too high
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            // Too low
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            // Victory condition
            else if (guess == magicNumber)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("----------------------------------");
                cont = false;
            }
        }
    }
}