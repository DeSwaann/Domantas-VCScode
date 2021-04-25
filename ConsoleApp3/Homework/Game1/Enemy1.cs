using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Homework.Game1
{
    class Enemy1
    {
        public int Id;
        public int X;
        public int Y;
        public string Name;

        public Enemy1(int id, int x, int y, string name)
        {
            Id = id;
            X = x;
            Y = y;
            Name = name;
        }
        public void MoveDown()
        {
            Y--;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Enemy {Name} is at {X}/{Y}");
        }
    }
}
