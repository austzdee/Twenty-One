using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class TwentyOneGame : Games, IWalkAway
    {
        public override void Play()
        {
            // Implementation of the game logic goes here
        }
        public override void ListPlayers()
        {
            // Custom implementation for listing players in TwentyOne game
            foreach (string player in Players)
            {
                Console.WriteLine($"Player: {player}");
            }
        }

        public void WalkAway(Player player)
        {
            Console.WriteLine($"{player.Name} has chosen to walk away from the game.");
            // Additional logic for handling the player walking away can be added here
        }
    }
}
