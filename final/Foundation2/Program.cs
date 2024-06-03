class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("435 Spring Creek Dr","Durango","CO","US");
        Customer customer1 = new Customer("Ezra Crandall", address1);

        Product product1 = new Product("Headphones","H2",25,4);
        Product product2 = new Product("Watch","W1",50.25,1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Cost: ${order1.GetTotalCost()}");

        Address address2 = new Address("123 Jonah Crandall Dr","Brazzaville","Brazzaville", "Republic of Congo");
        Customer customer2 = new Customer("Jonah Crandall",address2);

        Product product3 = new Product("FooFoo","F3",13.23,3);
        Product product4 = new Product("Book of Mormon","BOM11",11,1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Cost for order: ${order2.GetTotalCost()}");
    }
}