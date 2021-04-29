using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson14
{
    class Human : LiveObject
    {
        protected string _name;

        public override int GetLifeSpan()
        {
            return 420;
        }

        public Human (string name)
        {
            _name = name;
        }
    }
}
