using System;

namespace ConsoleApp3
{
    class Homework2
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite skaičių 1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite skaičių 2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite skaičių 3: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2 && skaicius2 > skaicius3 )
            {
                Console.WriteLine("Pirmasis skaičius didžiausias");
            }
            else if (skaicius1 < skaicius2 && skaicius2 > skaicius3)
            {
                Console.WriteLine("antrasis skaičius didžiausias");
            }
            else
            {
                Console.WriteLine("trečiasis skaičius didžiausias");
            }

            if (skaicius1 > skaicius2 && skaicius1 < 100)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą skaičių, bei yra mažesnis už šimtą");
            }
            else
            {
                Console.WriteLine("Pirmas skaičius mažesnis už antrą skaičių arba didesnis už šimtą.");
            }

            if (skaicius2 > 0 && skaicius2 > skaicius1)
            {
                Console.WriteLine("Antras skaičius didesnis už pirmą skaičių ir didesnis už nulį");
            }
            else
            {
                Console.WriteLine("Antras skaičius mažesnis už nulį arba pirmą skaičių");
            }
            if (skaicius1 > skaicius2 && skaicius2 < skaicius3 || skaicius1 >0 )
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą skaičių ir trečią skaičių arba yra teigiamas");
            }
            else
            {
                Console.WriteLine("Pirmas skaičius mažesnis už antrą skaičių arba trečią skaičių arba yra neigiamas");
            }
            if (skaicius3 >= 5 && skaicius3 <= 10 || skaicius3 > skaicius1 || skaicius3 > skaicius2)
            {
                Console.WriteLine("Skaičius atitinka sąlygą");
            }
            else
            {
                Console.WriteLine("Skaičius neatitinka sąlygos");
            }


        }
    }
}
