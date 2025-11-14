using System;
using System.Collections.Generic;
//using TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Please what is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Thank you {playerName}, enjoy your stay!");
            Console.WriteLine("How much money do you want to bet?");
            int playerBet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have placed a bet of {playerBet:C}.");
            Console.WriteLine($"Hello, {playerName}. would you like to play a game of 21 right now?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y")
            {
                Player player = new Player(playerName, playerBet);
                Game game = new TwentyOneGame();
                game.Players.Add(player);
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");



            }
            Console.WriteLine("Feel free to explore other areas.Bye for now.");
            Console.ReadLine();

        }
    }
}   

