namespace Lab2
{
    internal class Teacher: Person
    {
        public Teacher(string name, int age) : base(name, age) { }
        public override string ToString()
        {
            return $"Teacher: {this.name} ({this.age} y.o.)\n";
        }
    }
}
