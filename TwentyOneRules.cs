using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        public static int GetAllPossibleHandValues(List<Card> hand)
        {
            int aceCount = hand.Count(card => card.Face == Face.Ace);
            int minValue = hand.Sum(card => cardValues[card.Face]);
            int[] possibleValues = new int[aceCount + 1];
            possibleValues[0] = minValue;
            for (int i = 1; i <= aceCount; i++)
            {
                minValue += 10;
                possibleValues[i] = minValue;
            }
            return possibleValues.Where(value => value <= 21).DefaultIfEmpty(possibleValues.Min()).Max();
        }

        public static bool CheckForBlackjack(List<Card> hand)
        {
            return hand.Count == 2 && hand.Sum(card => cardValues[card.Face]) == 21;
        }
    }
}
