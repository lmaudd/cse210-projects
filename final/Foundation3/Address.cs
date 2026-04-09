using System;

public class Address : Event
{
    // Attributes
    private string _addressString;

    // Constructor
    public Address(string title, string description, string date, string time, Address address, string addressString): 
        base(title, description, date, time, address)
    {
        _addressString = addressString;
    }

    // Methods
    public string GetAddress()
    {
        return _addressString;
    }
}