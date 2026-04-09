using System;

public class OutdoorGathering : Event
{
    // Attributes
    private string _weather;

    // Constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather): 
        base(title, description, date, time, address)
    {
        _weather = weather;
    }

    // Methods
    // ...
}