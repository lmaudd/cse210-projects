using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Instantiate Address
        string streetAddress = "111 North Fake Street";
        string city = "City";
        string state = "State";
        string country = "Canada";

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

        // Order 2 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Instantiate Address
        string streetAddress2 = "111 North Fake Street";
        string city2 = "Rexburg";
        string state2 = "ID";
        string country2 = "USA";

        Address address2 = new Address(streetAddress2, city2, state2, country2);

        // Instiate Customer
        string name2 = "Tom Hanks";
        Customer customer2 = new Customer(name2, address2);

        // Create List of Products
        Product product12 = new Product("Slinky", "3473-0004", 2.99, 2);
        Product product22 = new Product("Yo-Yo", "ej20-0002", 2.99, 1);
        Product product32 = new Product("Hangers", "poll-gh89", 0.25, 60);
        Product product42 = new Product("Doorknob", "sev7-0001", 22.99, 2);
        Product product52 = new Product("Rug", "0090-aasr", 72.99, 1);

        List<Product> products2 = new List<Product>
        {
            product12, product22, product32, product42, product52
        };

        // Instantiate Order
        Order order2 = new Order(customer2, products2);

        // Test Class Methods
        double orderCost2 = order2.GetTotalCost();
        Console.WriteLine($"\nTotal Cost: ${orderCost2}");

        string shippngLabel2 = order2.GetShippingLabelString();
        Console.WriteLine($"\n{shippngLabel2}");

        string packingLabel2 = order2.GetPackingLabelString();
        Console.WriteLine($"\n{packingLabel2}\n");
    }
}