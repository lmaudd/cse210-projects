using System;
using System.IO;

// File: Journal.cs
//
// Class Purpose: This defined the journal. This is the only class that
// interfaces directly with the main program. It houses the instances of
// Entry and Prompts. I want to finish implementing the add prompt feature,
// but I would have to do so on the same instance that is used in GetEntry,
// and I am unsure how to fully implement that. 

public class Journal
{
    // Define responsibility to store all of the entries in our journal
    public List<Entry> _entries = new List<Entry>();

    // Use DateTime to get/format the current date
    static DateTime time = DateTime.Now; // Get current date from datetime
    static string date = time.ToShortDateString(); // date -> string as "mm/dd/yyyy"

    // Define methods
    public void GetEntry()
    {
        // This prompts the user, saves their answer, and stores it as an entry
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
        // This prints all entries at once (and handels formatting)
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
        // This saves your current entries as a file.
        // It doesn't just append them to an existing file.
        // It also requires you to set a pin which will be used to gain access upon load.
        Console.WriteLine(" ");
        Console.WriteLine("Saving Journal...");
        Console.Write("  - Please choose a filename (.txt): ");
        string fileName = Console.ReadLine(); // Save filename
        Console.Write("  - Please set a pin (4#): ");
        string pin = Console.ReadLine(); // Save pin
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
        // This loads the context of a previously saved .txt journal file
        // inot our current journal's entry list. It requires you to input
        // the correct pin to gain access. 
        Console.WriteLine(" ");
        Console.WriteLine("Loading Journal...");
        Console.Write("  - What is your file named? ");
        string fileName = Console.ReadLine(); 
        Console.Write("  - What is your pin? ");
        string pin = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.First() == pin) // Only proceed if the pin is correct
        {
            foreach (string line in lines) // Iterate through the whole file
            {
                if (line != lines.First()) // Skip the first line (I found .First() in stack overflow)
                {
                    // Sepearate a line of text by "~" and store its information in an Entry, 
                    // then add that Entry to our list of entries.
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
            Console.WriteLine("  - Incorrect password. Load Failed.");
            Console.WriteLine(" ");
        }
    }
}