using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            deck.Shuffle();
            deck.Print();

            Console.ReadKey();
        }
    }
}
