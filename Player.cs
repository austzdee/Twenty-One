using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name {  get; set; }
        public bool isActivelyPlaying {  get; set; }

        // operator overloading to add a Player to a Games instance
        public static Games operator +(Games game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        // operator overloading to remove a Player from a Games instance
        public static Games operator -(Games game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
