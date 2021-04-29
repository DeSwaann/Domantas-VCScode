using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson12
{
    class ThirdClass
    {
        private static int a = 0;
        public static int B = 0;
        private int c = 0;
        public int d = 0;

        public static int FifthMethod(int fifthInt)
        {
            a = fifthInt;
            fifthInt++;
            return fifthInt;
        }
        private static int SixthMethod(int sixthInt)
        {
            B = sixthInt;
            sixthInt++;
            return sixthInt;
        }
        public int SeventhMethod(int seventhInt)
        {
            c = seventhInt;
            seventhInt++;
            return seventhInt;
        }
        private int EightMethod(int eighthint)
        {
            d = eighthint;
            eighthint++;
            return eighthint;
        }
    }
}
