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
            // Deck test = new Deck();
            //test.CreateDeck();

            //for (int i = 0; i < test.fullDeck.Count; i++)
            //{
            //    Console.WriteLine(test.fullDeck[i]);
                
            //}
            Console.ReadLine();

        }

    }

    public abstract class Deck
    {
        //organised not shuffled
        protected List<PlayingCard> fullDeck = new List<PlayingCard>();

        //the fullDeck after shuffling -- the one we draw from
        protected List<PlayingCard> drawPile = new List<PlayingCard>();

        protected List<PlayingCard> discardPile = new List<PlayingCard>();
        public void CreateDeck()
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
        public abstract PlayingCard DealCard(int numberOFCards);

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

        //public override string ToString()
        //{
        //    return $"{Value} of {Suit}";
        //}
    }
    public enum CardSuit
    {
        Spades, Clubs, Diamonds, Hearts
    }
    public enum CardValue
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
}
