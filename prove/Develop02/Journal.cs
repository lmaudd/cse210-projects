using System;
using System.IO;

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

    public void DisplayAll()
    {
        Console.WriteLine(" ");
        Console.WriteLine("All Journal Entries");
        foreach (Entry item in _entries)
        {
            Console.WriteLine($"  - Date: {item._date} - Prompt: {item._prompt}");
            Console.WriteLine($"    {item._answer}");
        }
         Console.WriteLine(" ");
    }

    public void Save()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Saving Journal...");

        Console.Write("  - Please set a pin (4#): ");
        string pin = Console.ReadLine();

        Console.Write("  - Please choose a filename (.txt): ");
        string fileName = Console.ReadLine(); 

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(pin); // Begin by saving pin
            foreach (Entry item in _entries) // Save data
            {
                outputFile.WriteLine($"{item._date} ~ {item._prompt} ~ {item._answer}");
            }
        }

        Console.Write("  - Saving complete. ");
    }

    public void Load()
    {   
        Console.WriteLine(" ");
        Console.WriteLine("Loading Journal...");

        Console.Write("  - What is your pin? ");
        string pin = Console.ReadLine();

        Console.Write("  - What is your file named? ");
        string fileName = Console.ReadLine(); 
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[1];

            Entry entry = new Entry();
            entry.StoreInformation(prompt, answer, date);
        }
    }
}