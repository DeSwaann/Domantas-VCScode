using System;

namespace ConsoleApp3
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Įveskite skaičių 1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite skaičių 2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite skaičių 3: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            switch (skaicius1)
            {
                case 1: 
                    Console.WriteLine(skaicius1 + skaicius2 + skaicius3);
                        break;
                case 2: 
                    Console.WriteLine(skaicius1 - skaicius3);
                    break;

                case 3:
                    Console.WriteLine(skaicius2 * skaicius3);
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;

            }



        }

    }
}