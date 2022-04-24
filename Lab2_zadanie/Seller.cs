using System;

namespace Lab2_zadanie
{
    internal class Seller: Person
    {
        public Seller(string name, int age) : base(name, age) { }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"Seller: {Name} ({Age} y.o.)");
        }
    }
}
