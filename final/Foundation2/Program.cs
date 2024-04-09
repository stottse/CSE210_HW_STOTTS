using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product product1 = new Product("Iphone 15", "W123", 800.0, 2);
        Product product2 = new Product("Ipad", "G456", 500.0, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.TotalCost());

        Address address2 = new Address("456 Maple St", "Vancouver", "BC", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Product product3 = new Product("Hockey Stick", "T789", 100.0, 3);
        Product product4 = new Product("Ice Skates","C3PO", 150.0, 3 );
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.TotalCost());
    }
}
    
