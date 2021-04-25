using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Lesson10;

namespace ConsoleApp3.Lesson10
{
    class Bird : Animal
    {
        private string feathers;
        protected string Beak;
        public bool IfWaterBird;
        public string Name;
        public int Age;
        public bool IfWhite;

        public Bird(string feathers, string beak, bool ifWaterBird, string name, int age, bool ifWhite) : base (name, age, ifWhite)
        {
            this.feathers = feathers;
            Beak = beak;
            IfWaterBird = ifWaterBird;
            Name = name;
            Age = age;
            IfWhite = ifWhite;
        }

    }
}
