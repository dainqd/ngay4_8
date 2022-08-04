using System;
namespace task1
{
    class Program
    {
        public static void Main()
        {
            List<Product> inv = new List<Product>;
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("A", 8.2, 2));

            inv.Add(new Product("A", 3.5, 4);
            inv.Add(new Product("A", 1.8, 8));
            Console.WriteLine("Product List: ");
            foreach(Product i in inv)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}

