using System;

public class Video
{
    // Attributes
    public string _title; // Video Title
    public string _author; // Video Author (channel)
    public string _length; // Video Length in minutes
    public List<Comment> _comments; // List of comment instantiations

    // Constructor
    public Video(string title, string author, string length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    // Method to get the number of comments
    public int GetNumberComments()
    {
        return _comments.Count();
    }

    // Method to write video summary to console
    public void DisplayVideoSummary()
    {
        int numberComments = GetNumberComments(); // Calculate number of comments

        Console.WriteLine($"\n'{_title}' by {_author}; {_length} long with {numberComments} comments:");

        foreach (Comment com in _comments)
        {
            string author = com._name; // Get commentor name from class directly
            string text = com._text; // Get commentor comment from class directly
            Console.WriteLine($"  - {author} says '{text}'");
        }
    }
}