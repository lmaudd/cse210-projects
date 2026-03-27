using System;

class Assigment
{
    // Class attributes
    protected string _studentName;
    private string _topic;
    
    // Class Constructor
    public Assigment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

     // Class Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}