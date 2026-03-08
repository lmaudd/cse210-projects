using System;

// File: Entry.cs
//
// Class Purpose: Define "Entry" class, which is sort of like a compound 
// list to hold the date, prompt, and answer for each journal entry.

public class Entry
{
    // Define responsibilities to store journal entry information
    public string _date;   // String to store current date (mm/dd/yyyy)
    public string _prompt; // String to store prompt
    public string _answer; // String to store answer

    // Define method method to receive input and store in above variables
    public void StoreInformation(string date, string prompt, string answer)
    {
        // Store function parameters in the class responsibilites
        _prompt = prompt;
        _answer = answer;
        _date = date;
    }
}