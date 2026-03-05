using System;

public class Journal
{
    // Define member variables (responsibilities)
    public List<Entry> _entries = new List<Entry>();

    // Define methods
    public void GetEntry()
    {
        Prompts prompt = new Prompts();
        string newPrompt = prompt.PromptSelection();
        Console.WriteLine(newPrompt);
        string answer = Console.ReadLine();

        Entry entry = new Entry();
        entry.StoreInformation(newPrompt, answer);
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("Empty");
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            Console.WriteLine(" ");
            Console.WriteLine("All Journal Entries");
            Console.WriteLine($"  - Date: {item._date} - Prompt: {item._prompt}");
            Console.WriteLine($"    {item._answer}");
            Console.WriteLine(" ");
        }
    }
}