using System;
using System.Collections.Generic;

namespace Opdracht_2
{
    class DeckOfCards
    {
        private List<PlayingCard> allPlayingCards;

        public DeckOfCards()
        {
            allPlayingCards = new List<PlayingCard>();

            for (int i = 0; i < 4; i ++)
            {
                for (int j = 0; j < 13; j ++)
                {                   
                    allPlayingCards.Add(new PlayingCard());
                }
            }
        }

        public void Print()
        {
            foreach (PlayingCard singlePlayingCard in allPlayingCards)
            {
                Console.WriteLine(singlePlayingCard.ToString());
            }
        }

        public void Shuffle()
        {
            Random random = new Random();

            int playingCardsCount = allPlayingCards.Count;

            while (playingCardsCount > 1)
            {
                playingCardsCount -= 1;

                int randomNewPosition = random.Next(playingCardsCount + 1);

                PlayingCard originalCardValue = allPlayingCards[randomNewPosition];
                allPlayingCards[randomNewPosition] = allPlayingCards[randomNewPosition];
                allPlayingCards[randomNewPosition] = originalCardValue;
            }
        }
    }
}
