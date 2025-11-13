using System;
using System.Collections.Generic;
//using TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            // Demonstrating the Number struct with decimal property
            //Number number = new Number();
            //number.Amount = 7.5m;
            //Console.WriteLine(number.Amount);

            //Games game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "John";
            //game += player; // Using overloaded + operator to add player to game

            //game -= player;// Using overload - operator to remove player from game


            //Card card1 = new Card();
            //card1.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Spades);
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();

            //int count = deck.Cards.Count(x=> x.Face == Face.Ace);
            ////Shuffle the deck 3 times
            ////deck.Shuffle(3);
            //Console.WriteLine(count);

            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            foreach (Card card in newList)
            {
                Console.WriteLine($"{card.Face}");
            }



            //// Display the shuffled deck
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine($"{card.Face} of {card.Suit}");
            //}

            //// Display the total count and shuffle info
            //Console.WriteLine(deck.Cards.Count);       
            Console.ReadLine();
        }
    } 
}

