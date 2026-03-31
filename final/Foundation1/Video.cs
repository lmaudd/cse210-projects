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
}