using System;


namespace Lab2
{
    internal class Person: IEquatable<Person>
    {
        protected string name;
        protected int age;

        public string Name { get => this.name; }
        public int Age { get => this.age; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(other.name, this.name) && Object.Equals(other.age, this.age);
        }

        override public string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }
    }
}
