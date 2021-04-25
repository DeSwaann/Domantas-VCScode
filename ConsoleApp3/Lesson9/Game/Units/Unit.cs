using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson9.Game
{
    class Unit
    {
        protected int _x;
        protected int _y;
        protected string _name;

        public Unit(int X, int Y, string name)
        {
            _x = X;
            _y = Y;
            _name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Object {_name} is at {_x}x{_y}");
        }
    }
}
