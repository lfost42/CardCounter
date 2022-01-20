using System;
using System.Collections.Generic;

namespace CardCounterLibrary
{
    public class WarDeck : Deck
    {
        public WarDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCard()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int i = 0; i < 52; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }
}