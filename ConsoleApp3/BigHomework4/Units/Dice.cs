using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BigHomework4.DiceFolder
{
    class Dice
    {
        private int _numberOfDice;

        public Dice(int numberOfDice)
        {
            _numberOfDice = numberOfDice;
        }

        public void IncreaseDiceSize()
        {
            _numberOfDice++;
        }
        public void DecreaseDiceSize()
        {
            _numberOfDice--;
        }
        public int GetDiceSize()
        {
            return _numberOfDice;
        }
    }
}
