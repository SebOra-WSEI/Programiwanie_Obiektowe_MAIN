using System;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var byTypes = new ByType();
            var byExtension = new ByExtension();

            Console.WriteLine(byTypes.ToString());
            Console.WriteLine(byExtension.ToString());
        }
    }
}
