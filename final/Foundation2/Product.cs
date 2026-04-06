using System;
using System.Dynamic;

public class Product
{
    // Attribute
    private string _name;
    private string _productID;
    private float _unitCost;
    private int _quantity; 

    // Constructor
    public Product(string name, string productID, float unitCost, int quantity)
    {
        _name = name;
        _productID = productID;
        _unitCost = unitCost;
        _quantity = quantity;
    }

    // Methods
    public float GetTotalCost()
    {
        
    }
}