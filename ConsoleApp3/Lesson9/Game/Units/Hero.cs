using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lesson9.Game
{
    class Hero : Unit
    {


        public Hero(int x, int y, string name) : base(x, y, name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public void MoveRight()
        {
            _x++;
        }

        public void MoveLeft()
        {
            _x--;
        }


    }
}