using System.Collections.Generic;

namespace MiniProjects
{
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int numberOfCards = 0; numberOfCards < 5; numberOfCards++)
            {
                output.Add(DrawACard());
            }
            return output;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawACard()); //creating a new card for each discarded one
                discardPile.Add(card);     //and adding it to the discarded pile
            }
            return output;
        }
    }
}
