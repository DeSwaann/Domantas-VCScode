using ConsoleApp3.BigHomework4.DiceFolder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3.BigHomework4
{
    class Player
    {
        private List<int> scoreList;
        private Dice dice = new Dice(3);
        private DiceD6 diced6 = new DiceD6();
        
        public Player()
        {
            scoreList = new List<int>();
        }

        public int PlayerRollTheDice()
        {
            for (int i = 0; i < dice.GetDiceSize(); i++)
            {
                scoreList.Add(diced6.RollTheDice());
            }

            int result = scoreList.Sum();
            Console.WriteLine(result);
            return result;
        }
    }
}
