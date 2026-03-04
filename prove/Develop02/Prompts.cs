using System;
using System.Reflection;

public class Prompts
{
    // Define member variables (responsibilities)
    // Resource: https://www.geeksforgeeks.org/c-sharp/list-implementation-in-c-sharp/
    public List<string> _prompts = new List<string> 
    {
        "Prompt #1 placeholder", 
        "Prompt #2 placeholder",
        "Prompt #3 placeholder",
        "Prompt #4 placeholder",
        "Prompt #5 placeholder",
        "Prompt #7 placeholder",
        "Prompt #8 placeholder",
        "Prompt #9 placeholder",
        "Prompt #10 placeholder"
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