using System;

class WrtitingAssigment : Assigment
{
    // Class attributes
    private string _title;

     // Class constructors 
    public WrtitingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    
    // Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}