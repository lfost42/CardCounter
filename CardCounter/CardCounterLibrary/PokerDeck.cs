using System.Collections.Generic;
using CardCounterLibrary;

public class PokerDeck : Deck
{
    public PokerDeck()
    {
        CreateDeck();
        ShuffleDeck();
    }

    public override List<PlayingCardModel> DealCard()
    {
        List<PlayingCardModel> output = new List<PlayingCardModel>();

        for (int i = 0; i < 5; i++)
        {
            output.Add(DrawOneCard());
        }
        return output;
    }
}


