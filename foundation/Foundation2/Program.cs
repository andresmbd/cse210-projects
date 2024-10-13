using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P1001", 999.99m, 1);
        Product product2 = new Product("Mouse", "P1002", 19.99m, 2);

        Product product3 = new Product("Keyboard", "P2001", 49.99m, 1);
        Product product4 = new Product("Monitor", "P2002", 199.99m, 1);

        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        List<Product> order1Products = new List<Product> { product1, product2 };
        List<Product> order2Products = new List<Product> { product3, product4 };

        Order order1 = new Order(order1Products, customer1);
        Order order2 = new Order(order2Products, customer2);

        // Display information for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}\n");

        // Display information for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}