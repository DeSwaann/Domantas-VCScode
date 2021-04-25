using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Homework.Game1
{
    class Hero1
    {
       public int X;
       public int Y;
       public string Name;


        public Hero1(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public void MoveRight()
        {
            X++;
        }
        public void MoveLeft()
        {
            X--;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Hero {Name} is at {X}/{Y}");
        }
            

    }
}
