using System;

public class Address
{
    // Attributes
    private string _address;

    // Constructor
    public Address(string address)
    {
        _address = address;
    }

    // Methods
    public string GetAddress()
    {
        return _address;
    }
}