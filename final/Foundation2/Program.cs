class Program
{
    static void Main(string[] args)
    {

        Address address = new Address("123 Main Street", "Springfield", "Illinois", "USA");
        Customer customer1 = new Customer("John Smith", address);
        
        address = new Address("Carrera 45 #26-85", "Bogotá", "Cundinamarca", "Colombia");
        Customer customer2 = new Customer("Brian Madroñero", address);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        Product product = new Product("Coconut", 5285, 10.90, 10);
        order1.AddProduct(product);
        product = new Product("Watermelon", 5286, 20.21, 2);
        order1.AddProduct(product);

        Console.WriteLine("======= ORDER 1 =======");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());
        Console.Write($"\nTOTAL: {order1.CalculateTotalCost()}\n");

        product = new Product("Mouse", 1371, 100, 1);
        order2.AddProduct(product);
        product = new Product("Keyboard", 1372, 120, 1);
        order2.AddProduct(product);

        Console.WriteLine("======= ORDER 2 =======");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.Write($"\nTOTAL: {order2.CalculateTotalCost()}\n");
    }
}