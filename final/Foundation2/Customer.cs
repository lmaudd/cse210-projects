using System;

public class Customer
{
    // Attributes
    private string _name;
    private Address _address; 

    // Constructor 
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods
    public string GenerateShippingLabelString()
    {
        string shippingLabel = $"{_name}\n" + _address.GetFullAddress();
        return shippingLabel;
    }

    public bool GetIsInUSA()
    {
        bool isInUSA = _address.GetIsInUSA();
        return isInUSA;
    }
}