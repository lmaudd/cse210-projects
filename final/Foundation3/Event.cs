using System;

public class Event
{
    // Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // Constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Information Formatting Methods
    public string GetStandardDetails()
    {
        return $"Event Details:\n  - {_title}\n  - {_description}\n  - {_date}\n  - {_time}\n  - {_address}";
    }
}