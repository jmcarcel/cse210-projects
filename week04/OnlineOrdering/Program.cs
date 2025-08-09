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
    }
}