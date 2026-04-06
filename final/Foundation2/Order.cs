using System;

public class Order
{
    // Attributes
    private Customer _customer;
    private List<Product> _products;

    // Constructor 
    public Order(Customer customer, List<Product> products)
    {
        // construct here
        // ask if i should instantiate in constructor or in main (for now I will assume main since it will be easier)
        _customer = customer;
        _products = products;
    }

    // Methods
    private float GetShippingCost()
    {
        bool isInUSA = _customer.GetIsInUSA();

        if (isInUSA == true)
        {
            return 5;
        }

        else
        {
            return 35;
        }
    }

    public float GetTotalCost()
    {
        float cost = 0;

        cost += GetShippingCost();

        foreach (Product product in _products)
        {
            cost += product.GetTotalCost();
        }

        return cost;
    }

    public string GetShippingLabelString()
    {

    }

    public string GetPackingLabelString()
    {

    }
}