using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("769 Main St", "New York", "NY", "USA");
        Address internationalAddress = new Address("456 High St", "London", "England", "UK");

        // Create customers
        Customer customer1 = new Customer("Sergio Nieto", usaAddress);
        Customer customer2 = new Customer("Marion Nieto", internationalAddress);

        // Create products
        Product product1 = new Product("Laptop", "P100", 999.99, 1);
        Product product2 = new Product("Mouse", "P101", 19.99, 2);
        Product product3 = new Product("Keyboard", "P102", 49.99, 1);
        Product product4 = new Product("Monitor", "P103", 199.99, 2);
        Product product5 = new Product("Headphones", "P104", 79.99, 1);

        // Create first order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order information
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}