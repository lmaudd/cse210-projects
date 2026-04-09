using System;

public class Reception : Event
{
    // Attributes
    // N/A

    // Constructor
    public Reception(string title, string description, string date, string time, Address address): 
        base(title, description, date, time, address)
    {
    }

    // Methods
    public string GetFullDetails()
    {
        string fullDetails = GetStandardDetails();
        fullDetails += $"  - RSVP Email: put here"; // Add email for RSVP
        return fullDetails;
    }

    public void GetShortDescription(){} //Drop to child classes
}