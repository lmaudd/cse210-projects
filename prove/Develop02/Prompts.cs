using System;
using System.Reflection;

public class Prompts
{
    // Define member variables (responsibilities)
    // Resource: https://www.geeksforgeeks.org/c-sharp/list-implementation-in-c-sharp/
    public List<string> _prompts = new List<string> 
    {
        "hat was the best part of my day", 
        "What about my day could have gone better?",
        "What is one thing that inspired me today?",
        "Name one good deed I did today.",
        "Name one moment I felt peace today.",
        "What am I excited about for tomorrow?",
        "Did I make any new friends today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "Who was the most interesting person I interacted with today?"
    };

    // Define methods
    public string PromptSelection()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(9); // Randomly select from indices 0-9
        string chosenPrompt = _prompts[index]; // Store corresponding prompt
        return chosenPrompt;
    }

    public void AddPrompt(string newPrompt)
    {
        _prompts.Add(newPrompt);
    }
}