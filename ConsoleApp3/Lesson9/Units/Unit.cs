
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lesson9.Units
{
    class Unit
    {
        protected int X;
        protected int Y;
        protected string Name;

        public Unit(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Unit : {Name} {X}*{Y}");

        }
    }
}