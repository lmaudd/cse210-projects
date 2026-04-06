using System;

public class Address
{
    // Attributes
    private string _streetAddress;
    private string _city;
    private string _state; // Or Province
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }

    public bool GetIsInUSA()
    {
        bool isInUSA = false;

        if (_country == "USA")
        {
            isInUSA = true;
        }

        return isInUSA;
    }
}