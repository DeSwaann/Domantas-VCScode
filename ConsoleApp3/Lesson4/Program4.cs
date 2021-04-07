using System;

namespace ConsoleApp3
{
    class Program4

    {
        static void Main()
        {
            /*for (int i = 0; i<20; i += 3)
            {
                Console.WriteLine("I is: " + i);
            } 

            Console.Write("Įveskites pirmąjį skaičių: ");

            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskites antrąjį skaičių, kuris būtų didesnis už pirmąjį: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

           if (skaicius1 < skaicius2)
            {
                for (int i = skaicius1; i < skaicius2; i++)
                {
                    Console.WriteLine($"{i} {i * i}");

                }

            }
           else
            {
                Console.WriteLine("bad limits");
            } 


            int suma = 0;

             for (int i = 0; i < 1000; i++)
            {
                if ( i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
                
            }
            Console.WriteLine("Suma = " + suma); 
            Console.Write("Įveskite pasirinkimą: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            
            
            while (skaicius1 <1 || skaicius1 > 3)
            {
                Console.Write("Įveskite pasirinkimą: ");
                skaicius1 = Convert.ToInt32(Console.ReadLine());
            }
            switch (skaicius1)
            {

                case 1:
                    {
                        Console.WriteLine("Pasirinkote kavą");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Pasirinkote arbatą");

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Pasirinkote vandenį");

                        break;
                    }


            string input;
            const int totalSeatCount = 8;
            const int windowSeatCount = 4;
            const string yesAnswer = "yes";
            const string noAnswer = "no";
            int allSeatsTaken = 0;
            int windowSeatsTaken = 0;




            while (allSeatsTaken < totalSeatCount && windowSeatsTaken < windowSeatCount)
            {
                do
                {
                    Console.Write("Ar norite sėdėti prie lango? ");
                    input = Convert.ToString(Console.ReadLine());
                }
                while (input != yesAnswer && input != noAnswer);
                {

                    if (input == yesAnswer)
                    {
                        windowSeatsTaken++;
                    }
                }
                
                 allSeatsTaken++;
                
            }*/
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if ( i % 5 == 0)
                {
                    continue;
                }
                if ( i > 123)
                {
                    break;
                }
                sum += i;
            }

            Console.WriteLine("Skaičių suma:" + sum);





        }


    }

}