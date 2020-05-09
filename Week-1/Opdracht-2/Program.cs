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
            YahtzeeGame yahtzeeGame = new YahtzeeGame();

            SpeelYahtzee(yahtzeeGame);

            Console.ReadKey();
        }

        void SpeelYahtzee(YahtzeeGame game)
        {
            int aantalPogingen = 0;

            game.Gooi();
            game.ToonWorp();

            aantalPogingen++;

            while (!game.Yahtzee())
            {
                game.Gooi();
                game.ToonWorp();

                aantalPogingen++;
            } 

            Console.WriteLine("Aantal pogingen nodig voor yahtzee: {0}", aantalPogingen);
        }
    }
}
