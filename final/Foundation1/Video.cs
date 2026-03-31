using System;

public class Video
{
    public string _title;
    public string _author;
    public string _length; 
    public List<Comment> _comments;

    public Video(string title, string author, string length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetNumberComments()
    {
        return _comments.Count();
    }

    public void DisplayVideoSummary()
    {
        int numberComments = GetNumberComments();

        Console.WriteLine($"Name: {_title},  Author: {_author},  Length: {_length},  Comment Count: {numberComments}");

        foreach (Comment com in _comments)
        {
            string author = com._name;
            string text = com._text;
            Console.WriteLine($"  - {author}: {text}");
        }
    }
}