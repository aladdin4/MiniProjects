using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Poker myNewDeck = new Poker();
            
            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        protected List<PlayingCard> fullDeck = new List<PlayingCard>(); //organised not shuffled
        protected List<PlayingCard> drawPile = new List<PlayingCard>(); //the fullDeck after shuffling -- the one we draw from
        protected List<PlayingCard> discardPile = new List<PlayingCard>();


        protected void CreateDeck()
        {
            fullDeck.Clear();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }

        }
        public virtual void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(card => rnd.Next()).ToList();
        }
        public abstract List<PlayingCard> DealCards();
        public PlayingCard RequestCard()
        {
            var output = drawPile.Take(1).First();
            drawPile.Remove(output);

            return output;
        }
    }

    //single card type
    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }
    public enum CardSuit
    {
        Spades, Clubs, Diamonds, Hearts
    }
    public enum CardValue
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }


    public class Poker : Deck
    {
        public Poker()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public int MyProperty { get; set; }
        public List<PlayingCard> cardDeal = new List<PlayingCard>();
        public override List<PlayingCard> DealCards()
        {

            for (int numberOfCards = 0; numberOfCards < 5; numberOfCards++)
            {
                cardDeal.Add(RequestCard());
            }
            return cardDeal;
        }

    }



}
