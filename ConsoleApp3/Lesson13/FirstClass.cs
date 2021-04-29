using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson12
{
    class FirstClass
    {
        public static int x = 0;
        private static int Y = 0;

        public static int FirstMethod(int firstInt)
        {
            x = firstInt;
            firstInt++;
            return firstInt;
        }
        private static void SecondMethod(int secondInt)
        {
            Y = secondInt;
            secondInt++;
        }


    }
}
