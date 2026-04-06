// https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-10.0

using System;

public class Product
{
    // Attribute
    private string _name;
    private string _productID;
    private double _unitCost;
    private int _quantity; 

    // Constructor
    public Product(string name, string productID, double unitCost, int quantity)
    {
        _name = name;
        _productID = productID;
        _unitCost = unitCost;
        _quantity = quantity;
    }

    // Methods
    public double GetTotalCost()
    {
        double cost = _unitCost * _quantity;
        double costRound = Math.Round(cost, 2);
        return costRound;
    }

    public string GetNameAndID()
    {
        return $"{_name} ({_productID}) x{_quantity}";
    }
}