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
        return $"Event Details:\n  - Title: {_title}\n  - Description: {_description}\n  - Date: {_date}\n  - Time: {_time}\n  - Address:{_address}\n";
    }

    // Getters (Necessary Only) for use in "Short description - Lists the type of event, title, and the date."
    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }
}