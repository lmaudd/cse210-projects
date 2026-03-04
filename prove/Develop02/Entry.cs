using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    // Need to update _prompt when Prompt.cs works

    // Define member variables (responsibilities)
    public string _prompt = ""; // Pull a random prompt and store here

    static DateTime time = DateTime.Now; // Get current date from datetime
    public string _date = time.ToShortDateString(); // date -> string as "mm/dd/yyyy"
    
    public string _answer; // Store answer here

    // Define methods
    public void PromptUser()
    {
        Console.WriteLine(_prompt);
        _answer = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_answer);
    }
}