using System;
using System.Collections.Generic;

namespace Lab2_zadanie
{
    internal class Buyer : Person
    {
        List<Product> products = new List<Product>();

        public Buyer(string name, int age) : base(name, age) { }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int index)
        {
            products.RemoveAt(index);
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"Buyer: {Name} ({Age} y.o.)");
            if (products.Count > 0)
            {
                Console.WriteLine("\t\t-- Products: --");
            }
            foreach (Product product in products)
            {
                product.Print(prefix + "\t");
            }
        }
    }
}
