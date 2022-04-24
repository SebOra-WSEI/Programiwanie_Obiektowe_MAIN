using System;

namespace Lab2_zadanie
{
    internal class Person: IThing
    {
        public string name;
        public int age;
        public new string Name 
        {
            get => name;
            set => name = value;
        }
        public int Age 
        {
            get => age;
            set => age = value;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine("Person:");
        }
    }
}
