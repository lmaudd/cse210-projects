using System;
using System.Dynamic;

public class Entry
{
    // Define member variables (responsibilities)
    static DateTime time = DateTime.Now; // Get current date from datetime
    public string _date = time.ToShortDateString(); // date -> string as "mm/dd/yyyy"

    public string _prompt;
    public string _answer; // Store answer here

    // Define methods
    public void StoreInformation(string prompt, string answer, string date)
    {
        _prompt =  prompt;
        _answer = answer;

        if (date)
        {
            _date = date;    
        }
}