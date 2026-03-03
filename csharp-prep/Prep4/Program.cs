using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // Make List
        int newNumber = -1;                  // Initialize new number so we can use it for loop condition

        // Begin writing to console for clean output
        Console.WriteLine(" ");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to fill list
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");    // Ask question
            string input = Console.ReadLine();  // Store answer
            newNumber = int.Parse(input);       // Store answer as int

            if (newNumber != 0)                 // Store int in list IF its not 0 (for correct average)
            {                            
                numbers.Add(newNumber);            
            }
        }

        // Data Analysis
        int sum = numbers.Sum();             
        double average = numbers.Average();    
        int max = numbers.Max();            

        // Output
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
        Console.WriteLine($"Largest Number = {max}");
        Console.WriteLine(" ");
    }
}