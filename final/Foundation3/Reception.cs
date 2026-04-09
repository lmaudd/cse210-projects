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
    public void GetFullDetails(){} // Drop to child classes

    public void GetShortDescription(){} //Drop to child classes
}