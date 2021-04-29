using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson14
{
    class Dog : Pet
    {
        private string _name;
        public Dog (string name)
        {
            _name = name;
        }
        public override int GetLifeSpan()
        {
            return 42;
        }


    }
}
