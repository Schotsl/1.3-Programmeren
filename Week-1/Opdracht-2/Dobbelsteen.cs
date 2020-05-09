using System;

namespace Opdracht_2
{
    class Dobbelsteen
    {
        public int waarde;
        private Random random;

        public Dobbelsteen(Random random)
        {
            this.random = random;
        }

        public void Gooi()
        {
            waarde = random.Next(1, 7);
        }

        public void ToonWaarde()
        {
            Console.Write(waarde);
        }
    }
}