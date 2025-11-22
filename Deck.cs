using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); // create empty deck
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
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

        public void Shuffle(int times = 1)
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
