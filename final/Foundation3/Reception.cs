using System;

public class Reception : Event
{
    // Attributes
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail): 
        base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Methods
    public string GetFullDetails()
    {
        string fullDetails = GetStandardDetails();
        fullDetails += $"  - RSVP Email: {_rsvpEmail}";
        return fullDetails;
    }

    public override string GetEventType()
    {
        return "Reception";
    }
}