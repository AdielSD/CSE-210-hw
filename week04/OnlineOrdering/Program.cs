class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Products
        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 49.99, 2);
        Product product3 = new Product("Keyboard", 103, 79.99, 1);

        // Create Orders
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product2, product3 });

        // Display Results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost():C}");
    }
}
