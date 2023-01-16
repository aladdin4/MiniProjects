using System;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //public CardSuit Suit { get; set; }
            //public CardValue Value { get; set; }

            PokerDeck pokerCards = new PokerDeck();
            var cards = pokerCards.DealCards();
            foreach (var card in cards)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.WriteLine("----------------------------------------------------------");

            BlackJackDeck blackJackCards = new BlackJackDeck();
            var otherCards = blackJackCards.DealCards();
            foreach (var card in otherCards)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.ReadLine();
        }
    }

}
