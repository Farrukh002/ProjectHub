using System;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.setCode("PC-001");
            product.setDateOfOutcome(new DateTime(2022, 10, 23, 23, 59, 45));
            product.setAvailability(true);
            product.setName("Home-PC");
            product.setPrice(1500.3);
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
