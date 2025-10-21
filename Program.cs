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


            foreach (Cards card in deck.Card)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Card.Count);
            Console.ReadLine();
        }
        
    }

    
}