using System;
using System.Runtime.CompilerServices;

public class Lecture : Event
{
    // Attributes
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capcacity): 
        base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capcacity;
    }

    // Methods
    public string GetFullDetails()
    {
        string fullDetails = GetStandardDetails();
        fullDetails += $"  - Speaker: {_speaker}\n  - Capacity: {_capacity}";
        return fullDetails;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }
}