using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_3
{
    class Player
    {
        public string name;
        public List<PlayingCard> playingCards;

        public Player(string name)
        {
            this.name = name;
            this.playingCards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard playingCard)
        {
            playingCards.Insert(0, playingCard);
        }

        public PlayingCard GetNextCard()
        {
            if (!playingCards.Any())
            {
                throw new InvalidOperationException("The player has no more cards");
            }

            PlayingCard playingCard = playingCards.First();
            playingCards.RemoveAt(0);
            return playingCard;
        }

        public bool hasCards()
        {
            return playingCards.Any();
        }
    }
}
