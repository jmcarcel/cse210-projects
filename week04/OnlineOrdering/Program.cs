using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("456 Main St.", "Manhattan", "NY", "USA");
        Customer customer1 = new Customer("Abel Johnson", address1);
        Product product1 = new Product("Book", "A001", 14.99, 2);
        Product product2 = new Product("Pen", "A002", 1.99, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: {order1.GetTotalCost()}");

        Address address2 = new Address("Domingo Candia 2844", "Rosario", "Santa Fe", "Argentina");
        Customer customer2 = new Customer("Joan Carcel", address2);
        Product products1 = new Product("Soda", "S001", 2.50, 5);
        Product products2 = new Product("Water", "S002", 0.99, 5);

        Order order2 = new Order(customer2);
        order2.AddProduct(products1);
        order2.AddProduct(products2);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: {order2.GetTotalCost()}");
    }
}