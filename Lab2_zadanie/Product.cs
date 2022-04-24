using System;

namespace Lab2_zadanie
{
    internal class Product
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public Product(string name)
        {
            this.name = name;
        }
        public virtual void Print(string prefix)
        {
            Console.WriteLine("Product:");
        }
    }
}
