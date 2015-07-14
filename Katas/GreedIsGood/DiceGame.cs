using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.GreedUsGood
{
    public struct DiceGame
    {
        public int GetScore(int[] dice)
        {
            int score = 0;
            foreach (var die in dice)
            {
                if (die == 1) score += 100;
                if (die == 5) score += 50;
            }
            if (containsThree(dice, 1)) score += 700;
            if (containsThree(dice, 2)) score += 200;
            if (containsThree(dice, 3)) score += 300;
            if (containsThree(dice, 4)) score += 400;
            if (containsThree(dice, 5)) score += 350;
            if (containsThree(dice, 6)) score += 600;
            return score;
        }

        private static bool containsThree(int[] dice,int num)
        {
            return dice.Count(x => x == num) >= 3;
        }
    }
}
