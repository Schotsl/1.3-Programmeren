using System;

namespace Opdracht_1
{
    class Programmer
    {
        private string name;
        private Specialty specialty;

        public Programmer(string name, Specialty specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }

        public Programmer(string name)
        {
            this.name = name;
            this.specialty = Specialty.Unknown;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Specialty: {specialty}");
        }
    }
}
