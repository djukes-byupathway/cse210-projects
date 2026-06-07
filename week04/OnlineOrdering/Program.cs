using System;
using System.Security.Cryptography;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Online Ordering Project.");


        Address addr1 = new Address("1304 Harold Ave.", "Simi Valley", "CA", "USA");
        Customer cust1 = new Customer("David Jukes", addr1);
        Product prod1 = new Product("pencil", "stat001", 0.25, 5);
        Product prod2 = new Product("ball point pen", "stat003", 0.32, 8);
        Product prod3 = new Product("writing pad", "stat015", 4.39, 2);
        List<Product> products1 = [prod1, prod2, prod3];
        Order ord1 = new Order(cust1, products1);
        Console.WriteLine();
        Console.WriteLine(ord1.getShippingLabel());
        Console.WriteLine();
        Console.WriteLine(ord1.getPackingLabel());
        Console.WriteLine(ord1.getShippingCost().ToString("C", new CultureInfo("en-US")));
        Console.WriteLine(ord1.getOrderTotal().ToString("C", new CultureInfo("en-US")));

        Address addr2 = new Address("777 Heavenly Way", "Zion", "TX", "Venus");
        Customer cust2 = new Customer("Amy Jukes", addr2);
        Product prod4 = new Product("lipstick", "mkup001", 10.67, 2);
        Product prod5 = new Product("eye liner", "mkup001", 9.35, 3);
        List<Product> products2 = [prod4, prod5]; //
        Order ord2 = new Order(cust2, products2);

        Console.WriteLine();
        Console.WriteLine(ord2.getShippingLabel());
        Console.WriteLine();
        Console.WriteLine(ord2.getPackingLabel());
        Console.WriteLine($"Shipping Cost: {ord2.getShippingCost().ToString("C", new CultureInfo("en-US"))}");
        Console.WriteLine($"Order Total: {ord2.getOrderTotal().ToString("C", new CultureInfo("en-US"))}");
    }
}