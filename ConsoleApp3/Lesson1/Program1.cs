using System;

namespace ConsoleApp3
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite vardą: ");
            string myName = (Console.ReadLine());
            Console.Write("Įveskite pavardę: ");
            string myName2 = (Console.ReadLine());
            Console.WriteLine(myName + " " + myName2);
        }
    }
}
