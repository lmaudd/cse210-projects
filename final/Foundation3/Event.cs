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

    // Methods for Short Description (reworked to avoid duplicate code)
    public virtual string GetEventType()
    {
        return "";
    }

    public string GetShortDescription()
    {
        string type = GetEventType();
        string title = _title;
        string date = _date;

        string shortDescription = $"Short Description: {title} is a {type} Event on {date}.";
        return shortDescription;
    }
}