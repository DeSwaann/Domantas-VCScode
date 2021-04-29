using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson12
{
    class SecondClass
    {
        private int z = 0;
        public int W = 0;

        public int ThirdMethod(int thirdInt)
        {
            z = thirdInt;
            thirdInt++;
            return thirdInt;
        }
        private int FourthMethod(int fourthInt)
        {
            W = fourthInt;
            fourthInt++;
            return fourthInt;
        }


    }
}