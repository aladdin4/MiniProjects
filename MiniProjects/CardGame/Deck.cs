using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProjects
{
    public abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>(); //organised not shuffled
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>(); //the fullDeck after shuffling -- the one we draw from
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();


        protected void CreateDeck()
        {
            fullDeck.Clear();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }

        }
        public virtual void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(card => rnd.Next()).ToList();
        }
        public abstract List<PlayingCardModel> DealCards();
        protected PlayingCardModel DrawACard()  //will be from DB at some point -- for creating new cards
        {
            var output = drawPile.Take(1).First();
            drawPile.Remove(output);

            return output;
        }
    }

}
