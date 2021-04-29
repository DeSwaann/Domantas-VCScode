using System;
using ConsoleApp3.Lesson12;

namespace ConsoleApp3
{
    class Recall
    {
        static void Main(string[] args)
        {
            FirstClass first = new FirstClass();
            SecondClass second = new SecondClass();
            ThirdClass third = new ThirdClass();

            Console.WriteLine(FirstClass.FirstMethod(0));
            Console.WriteLine(second.ThirdMethod(0));
            Console.WriteLine(third.SeventhMethod(0));
            Console.WriteLine(ThirdClass.FifthMethod(0));


        }
    }
}
