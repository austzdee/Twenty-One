using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card() 
        { 
        
                Face = "King";
                Suit = Suit.Diamonds;

        }
        public string Face { get; set; }
        public Suit Suit { get; set; }     
    }
    public enum Suit
    {
        Clubs,
        Hearts,
        Diamonds,
        Spades
    }
}