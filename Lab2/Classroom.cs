using System;

namespace Lab2
{
    internal class Classroom
    {
        private string name;
        private Person[] persons;

        public Person[] Persons { get => this.persons; }

        public Classroom(string name, Person[] person)
        {
            this.name = name;
            this.persons = person;
        }

        public override string ToString()
        {
            string result = "";
            result += $"Classroom: {this.name}\n\n";
            for (int i = 0; i < persons.Length; i++)
            {
                result += persons[i].ToString();
            }
            return result;
        }
    }
}
