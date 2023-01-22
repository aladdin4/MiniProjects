using System;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    class Program
    {

        static void Main(string[] args)
        {

            /// <summary>
            /// The Card Game Init.
            /// </summary>
            //PokerDeck pokerCards = new PokerDeck();
            //var cards = pokerCards.DealCards();
            //foreach (var card in cards)
            //{
            //    Console.WriteLine($"{card.Value} of {card.Suit}");
            //}
            //Console.WriteLine("----------------------------------------------------------");
            //BlackJackDeck blackJackCards = new BlackJackDeck();
            //var otherCards = blackJackCards.DealCards();
            //foreach (var card in otherCards)
            //{
            //    Console.WriteLine($"{card.Value} of {card.Suit}");
            //}


            Person tim = new Person("Tim", "Corey");
            tim.PrintPerson();
            Console.WriteLine($"outside person name is: {tim.FirstName} {tim.LastName}");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public static class Extensions
    {
        public static void PrintPerson(this Person person)
        {
            person.FirstName = "changed";
            person.LastName = "changed";
            Console.WriteLine($"current person name is: {person.FirstName} {person.LastName}");

        }
    }

}
