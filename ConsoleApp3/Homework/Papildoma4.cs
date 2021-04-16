using System;

namespace ConsoleApp3
{
    class Papildoma4
    {
        static void Main(string[] args)
        {
            //var input = Convert.ToInt32(Console.ReadLine());
            //var fibonatiResult = ForFibonati(input);
            //Console.WriteLine(fibonatiResult);

            DoSomething(5);
        }
        static int ForFibonati(int endNumber)
        {
            int fibonatiResult = 0;
            for (int g = 0; g <= endNumber;)
            {
               
            }
            
            
            return fibonatiResult;
        }
        static void DoSomething (int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }   

}
