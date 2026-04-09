using System;

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
    // ...
}