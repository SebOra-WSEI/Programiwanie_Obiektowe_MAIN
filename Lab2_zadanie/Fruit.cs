using System;


namespace Lab2_zadanie
{
    internal class Fruit: Product
    {
        private int count;
        public int Count
        {
            get => count;
            set => count = value;
        }

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }

        public override void Print(string prefix)
        {
            string[] temp = { "fruit", "fruits" };
            Console.WriteLine(prefix + $"{Name} ({count} " +
                $"{(count > 1 ? temp[0] : temp[1])}" + $")");
        }
    }
}
