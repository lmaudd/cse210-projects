using System;

class Assigment
{
    // Class attributes
    private string _studentName;
    private string _topic;

     // Class constructors 
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}