using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); // create empty deck
            for(int i = 0;i< 13; i++) // loop through faces
            {
                for(int j = 0; j < 4; j++) // loop through suits
                {
                    Card card = new Card(); // create a new card
                    card.Face = (Face)i; // assign face
                    card.Suit = (Suit)j; // assign suit
                    Cards.Add(card); // add the card to the deck
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
