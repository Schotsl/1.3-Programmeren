using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_3
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

        public List<PlayingCard>[] DivideCards(int divider)
        {
            List<PlayingCard>[] dividedCards = new List<PlayingCard>[divider];

            for (int i = 0; i < divider; i ++)
            {
                dividedCards[i] = new List<PlayingCard>();
            }

            int player = 0;

            for (int j = 0; j < allPlayingCards.Count; j++)
            {
                dividedCards[player].Add(allPlayingCards.ElementAt(j));

                player++;

                if (player == divider)
                {
                    player = 0;
                }
            }

            return dividedCards;
        }
    }
}
