using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
    {
        class Program
    {
        static void Main(string[] args)
        {
         
            Deck deck = new Deck();
            Deck shuffledDeck = Shuffle(deck);

            foreach (Cards card in deck.Card)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Card.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
           List<Cards> cards = new List<Cards>();
              Random random = new Random();
              while (deck.Card.Count > 0) 
              {
                  int randomIndex = random.Next(0, deck.Card.Count);
                  cards.Add(deck.Card[randomIndex]);
                  deck.Card.RemoveAt(randomIndex);
            }   
              deck.Card = cards;
                return deck;

        }

    }

    
}