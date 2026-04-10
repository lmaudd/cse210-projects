using System;

class Listing : Activity
{
    // Attributes
    private List<string> _prompts;

    // Constructor
    public Listing(): base()
    {
        // Set Name & Description
        string name = "Listing Activity";

        string description = "This activity will help you reflect on the good things in your life " +
                             "by having you list as many things as you can in a certain area.";

        SetName(name);
        SetDescription(description);

        // Set Prompts
        _prompts = new List<String>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Methods
    private string GetPrompt() // Method to choose a prompt
    {
        Random random = new Random();
        int counts = _prompts.Count();
        int randomIndex = random.Next(counts);
        return _prompts[randomIndex];
    }

    public void ListingActivity()
    {
        // Pick a prompt
        string prompt = GetPrompt();

        // Speak with user
        StartingMessage();
        int seconds = InquireTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.Write("You may begin in...");
        CountDown(5);

        // Define time keeping variables
        DateTime startTime = DateTime.Now; // Initial Time
        DateTime currentTime = DateTime.Now; // Current time for calc.
        int timeElapsed = CalculateTimeChange(startTime, currentTime);

        // Main Loop of activity
        int i = 0;
        while (timeElapsed < seconds)
        {
            // Main function
            Console.Write($"\n > ");
            Console.ReadLine();
            i++;

            // Update time keepers
            currentTime = DateTime.Now; // Current time for calc.
            timeElapsed = CalculateTimeChange(startTime, currentTime);
        }

        EndingMessage(seconds);
        Console.WriteLine($"You came up with {i} things!\n");
        Spinner(3);
    }
}