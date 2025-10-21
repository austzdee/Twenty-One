﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public  class Deck
    {
        public Deck() { 
            Card = new List<Cards>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades"};
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Cards card = new Cards();
                    card.Face = face;
                    card.Suit = suit;
                    Card.Add(card);
                }
            }

        }
        public List <Cards> Card { get; set; }
    }
}
