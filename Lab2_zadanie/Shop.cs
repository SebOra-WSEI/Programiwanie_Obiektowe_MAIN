using System;


namespace Lab2_zadanie
{
    internal class Shop
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        private Person[] people;
        private Product[] products;

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine($"Shop: {name}");
            Console.WriteLine("-- People: --");
            foreach (Person person in people)
            {
                person.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (Product product in products)
            {
                product.Print("\t");
            }
        }
    }
}
