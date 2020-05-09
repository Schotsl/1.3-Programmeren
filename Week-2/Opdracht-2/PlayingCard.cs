using System;

namespace Opdracht_2
{
    class PlayingCard
    {
        public CardRank rank;
        public CardSuit suit;

        public PlayingCard()
        {
            Random random = new Random();

            int cardSuitLength = CardSuit.GetNames(typeof(CardSuit)).Length;
            int cardRankLength = CardRank.GetNames(typeof(CardRank)).Length;

            suit = (CardSuit)random.Next(cardSuitLength);
            rank = (CardRank)random.Next(cardRankLength);
        }

        public override string ToString()
        {
            string formattedString = $"{rank} of {suit}";

            //Quick hack: an enumater can't start with a number so I added an underscore
            string hackedString = formattedString.Replace("_", "");

            return hackedString;
        }
    }
}
