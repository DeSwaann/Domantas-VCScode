using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BigHomework4.DiceFolder
{
    class DiceD6
    {
        private int _rolledEyes;

        public int RollTheDice()
        {
            Random r = new Random();
            _rolledEyes = r.Next(1, 6);
            //Console.WriteLine(_rolledEyes);
            return _rolledEyes;
        }
    }
  
}
