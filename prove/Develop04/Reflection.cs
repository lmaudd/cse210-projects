// https://stackoverflow.com/questions/283476/best-way-to-break-long-strings-in-c-sharp-source-code

using System;
using System.Diagnostics.CodeAnalysis;

class Reflection : Activity
{
    // Attributes
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public Reflection() : base()
    {
        // Set Name and Description
        string name = "Reflection Activity";

        string description = "This activity will help you reflect on times in your life " +
                             "when you have shown strength and resilience. This will help " +
                             "you recognize the power you have and how you can use it in " +
                             "other aspects of your life.";

        SetName(name);
        SetDescription(description);

        // Set Prompts and Questions
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

     // Method to pull a random prompt and question for use in activity execution
    private string GetPrompt()
    {
        Random random = new Random();
        int counts = _prompts.Count();
        int randomIndex = random.Next(counts);
        return _prompts[randomIndex];
    }

    private string GetQuestion()
    {
        Random random = new Random();
        int counts = _questions.Count();
        int randomIndex = random.Next(counts);
        return _questions[randomIndex];
    }

    // Main Reflection Activity
    public void ReflectionActivity()
    {
        // Pick a prompt
        string prompt = GetPrompt();

        // Speak with user
        StartingMessage();
        int seconds = InquireTime();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        PressEnter();
        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
        Console.Write("You may begin in...");
        CountDown(3);
        Console.Clear();

        // Define time keeping variables
        DateTime startTime = DateTime.Now; // Initial Time
        DateTime currentTime = DateTime.Now; // Current time for calc.
        int timeElapsed = CalculateTimeChange(startTime, currentTime);

        // Main Loop of activity
        while (timeElapsed < seconds)
        {
            // Main function
            string question = GetQuestion(); // Get question
            Console.Write($"\n > {question}  ");
            Spinner(4);

            // Update time keepers
            currentTime = DateTime.Now; // Current time for calc.
            timeElapsed = CalculateTimeChange(startTime, currentTime);
        }

        Console.WriteLine();
        EndingMessage(seconds);
    }
}