using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Address
        string streetAddress = "111 North Fake Street";
        string city = "City";
        string state = "State";
        string country = "USA";

        Address address = new Address(streetAddress, city, state, country);

        // Instiate Customer
        string name = "Jon Doe";
        Customer customer = new Customer(name, address);

        // Create List of Products
        Product product1 = new Product("Dog Toy", "he73-dk28", 4.28, 3);
        Product product2 = new Product("Ball", "ej20-2ion", 0.99, 3);
        Product product3 = new Product("Beyblade", "ej82-mm89", 2.33, 2);
        Product product4 = new Product("Shovel", "nn23-0001", 2.99, 4);
        Product product5 = new Product("Box", "kjsy-8001", 0.67, 6);

        List<Product> products = new List<Product>
        {
            product1, product2, product3, product4, product5
        };

        // Instantiate Order
        Order order = new Order(customer, products);

        // Test Class Methods
        double orderCost = order.GetTotalCost();
        Console.WriteLine($"\nTotal Cost: ${orderCost}");

        string shippngLabel = order.GetShippingLabelString();
        Console.WriteLine($"\n{shippngLabel}");

        string packingLabel = order.GetPackingLabelString();
        Console.WriteLine($"\n{packingLabel}\n");
    }
}