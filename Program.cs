using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            
            // Shuffle the deck 3 times
            deck.Shuffle();

            // Display the shuffled deck
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }

            // Display the total count and shuffle info
            Console.WriteLine($"\nTotal cards in deck: {deck.Cards.Count}");
           

            Console.ReadLine();
        }
    }
}

