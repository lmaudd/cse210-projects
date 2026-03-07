using System;
using System.Dynamic;

public class Entry
{
    // Define member variables (responsibilities)
    public string _date;
    public string _prompt;
    public string _answer;

    // Define methods
    public void StoreInformation(string date, string prompt, string answer)
    {
        _prompt =  prompt;
        _answer = answer;
        _date = date;
    }
}