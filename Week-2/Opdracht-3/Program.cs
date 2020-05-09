using System;

namespace Opdracht_3
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
            Player playerOne = new Player("Sjors");
            Player playerTwo = new Player("Martin");

            WarCardGame warCardGame = new WarCardGame(playerOne, playerTwo);
            PlayTheGame(warCardGame);

            Console.ReadKey();
        }

        void PlayTheGame(WarCardGame warCardGame)
        {
            warCardGame.StartNewGame();

            while (!warCardGame.EndOfGame())
            {
                warCardGame.NextCard();
            }

            Player winner = warCardGame.WhoIsWinner();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{winner.name} has won!");
            Console.ResetColor();
        }
    }
}
