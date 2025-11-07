using System;
using System.Collections.Generic;
//using TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {


            //Games game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "John";
            //game += player; // Using overloaded + operator to add player to game

            //game -= player;// Using overload - operator to remove player from game


            Card card1 = new Card();
            card1.Suit = Suit.Clubs;
            int underlyingValue = (int)card1.Suit;
            Console.WriteLine(underlyingValue);

            Deck deck = new Deck();            
             //Shuffle the deck 3 times
            deck.Shuffle(18);

            // Display the shuffled deck
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }

            // Display the total count and shuffle info
            Console.WriteLine(deck.Cards.Count);       
            Console.ReadLine();
        }
    } 
}

