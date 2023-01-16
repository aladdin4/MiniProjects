using System.Collections.Generic;

namespace MiniProjects
{
    public class BlackJackDeck : Deck
    {
        public BlackJackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int numberOfCards = 0; numberOfCards < 2; numberOfCards++)
            {
                output.Add(DrawACard());
            }
            return output;
        }

        public PlayingCardModel RequestCard()
        {
            return DrawACard();
        }
    }
}
