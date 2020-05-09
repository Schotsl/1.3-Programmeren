using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_3
{
    class WarCardGame : CardGame
    {
        private Player playerOne;
        private Player playerTwo;

        public WarCardGame(Player playerOne, Player playerTwo) : base()
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public void StartNewGame() {
            deckOfCards.Shuffle();

            List<PlayingCard>[] dividedCards = deckOfCards.DivideCards(2);

            for (int i = 0; i < dividedCards[0].Count; i ++)
            {
                playerOne.AddCard(dividedCards[0].ElementAt(i));
            }

            for (int j = 0; j < dividedCards[1].Count; j++)
            {
                playerTwo.AddCard(dividedCards[1].ElementAt(j));
            }
        }

        public bool EndOfGame()
        {
            return !playerOne.hasCards() || !playerTwo.hasCards();
        }

        public Player WhoIsWinner()
        {
            if ((int)playerOne.playingCards.Count > (int)playerTwo.playingCards.Count)
            {
                return playerOne;
            }

            return playerTwo;
        }

        public void NextCard()
        {
            PlayingCard playerOnePlayingCard = playerOne.GetNextCard();
            PlayingCard playerTwoPlayingCard = playerTwo.GetNextCard();

            Console.ResetColor();
            Console.WriteLine($"[{playerOne.name}] {playerOnePlayingCard.ToString()} | [{playerTwo.name}] {playerTwoPlayingCard.ToString()}");

            if ((int)playerOnePlayingCard.rank > (int)playerTwoPlayingCard.rank)
            {
                playerOne.AddCard(playerOnePlayingCard);
                playerOne.AddCard(playerTwoPlayingCard);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{playerOne.name} Got the cards\n");
            }
            else if ((int)playerOnePlayingCard.rank < (int)playerTwoPlayingCard.rank)
            {
                playerTwo.AddCard(playerOnePlayingCard);
                playerTwo.AddCard(playerTwoPlayingCard);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{playerTwo.name} Got the cards\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No one recieved the cards\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Cards left:");
                Console.WriteLine($"[{playerOne.name}]: {playerOne.playingCards.Count}]");
                Console.WriteLine($"[{playerTwo.name}]: {playerTwo.playingCards.Count}]");
                Console.WriteLine();
            }
        }
    }
}
