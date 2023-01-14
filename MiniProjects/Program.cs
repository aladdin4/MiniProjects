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
        }
    }

    public abstract class Deck
    {
        public void CreateDeck()
        {
        }
        public void ShuffleDeck()
        {
        }
        public abstract List<PlayingCard> DealCard(int numberOFCards);
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
}
