using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson14
{
    class Pet : LiveObject
    {
        public override int GetLifeSpan()
        {
            return 42;
        }
    }
}
