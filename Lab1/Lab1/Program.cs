using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new Ulamek(7, 3);
            var y = new Ulamek(6, 3);

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());

            Console.WriteLine(x.ToInt());

            Console.WriteLine(x.CompareTo(y));
        }
    }
}
