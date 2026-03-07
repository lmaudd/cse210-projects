using System;
using System.IO;

public class Journal
{
    // Define member variables (responsibilities)
    public List<Entry> _entries = new List<Entry>();

    // Get Date
    static DateTime time = DateTime.Now; // Get current date from datetime
    static string date = time.ToShortDateString(); // date -> string as "mm/dd/yyyy"

    // Define methods
    public void GetEntry()
    {
        Prompts prompt = new Prompts();
        string newPrompt = prompt.PromptSelection();
        Console.WriteLine(" ");
        Console.WriteLine(newPrompt);
        string answer = Console.ReadLine();

        Entry entry = new Entry();
        entry.StoreInformation(date, newPrompt, answer);
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
        Console.WriteLine(" ");
    }

    public void Load()
    {   
        Console.WriteLine(" ");
        Console.WriteLine("Loading Journal...");
        Console.Write("  - What is your file named? ");
        string fileName = Console.ReadLine(); 
        Console.Write("  - What is your pin? ");
        string pin = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.First() == pin)
        {
            foreach (string line in lines)
            {
                if (line != lines.First())
                {
                    string[] parts = line.Split("~");
                    string date = parts[0];
                    string prompt = parts[1];
                    string answer = parts[2];
                    Entry entry = new Entry();
                    entry.StoreInformation(date, prompt, answer);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("  - Load successful.");
        }

            else
        {
            Console.WriteLine("Incorrect password. Load Failed.");
            Console.WriteLine(" ");
        }
    }
}