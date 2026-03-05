using System;
using System.IO;

public class Journal
{
    // Define member variables (responsibilities)
    public List<Entry> _entries = new List<Entry>();
    public string _pin;
    public string _fileName;

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
        _pin = Console.ReadLine();
        Console.Write("  - Please choose a filename (.txt): ");
        _fileName = Console.ReadLine(); 

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_pin); // Begin by saving pin
            foreach (Entry item in _entries) // Save data
            {
                outputFile.WriteLine($"{item._date} ~ {item._prompt} ~ {item._answer}");
            }
        }

        Console.Write("  - Saving complete. ");
    }

    public void Load()
    {

    }
}