using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); // create empty deck
            List<string> suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            foreach (string face in faces)
            {
                foreach (string suit in suits)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }
        }

        // List of all cards in the deck
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 3)
        {
            Random random = new Random();

            for (int i = 0; i < times; i++)
            {
                List<Card> shuffled = new List<Card>();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    shuffled.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }

                Cards = shuffled;
            }
        }
    }
}
