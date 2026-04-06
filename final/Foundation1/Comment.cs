using System;

public class Comment
{
    // Attributes
    private string _name; // Name of commentor
    private string _text; // Full text of comment

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"  - {_name} says '{_text}'");
    }
}