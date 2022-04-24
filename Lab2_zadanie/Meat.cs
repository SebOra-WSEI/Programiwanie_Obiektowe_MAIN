using System;

namespace Lab2_zadanie
{
    internal class Meat: Product
    {
        private double weight;
        public double Weight
        {
            get => this.weight;
            set => weight = value;
        }

        public Meat(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"{Name} ({weight} kg)");
        }
    }
}
