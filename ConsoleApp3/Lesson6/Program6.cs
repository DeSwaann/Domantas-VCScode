using System;

namespace ConsoleApp3
{
    class Program6
    {
        static void Main ()
        {
            InputArray();
        }

        static void InputArray ()
        {
            var masyvas = Input();

            Console.WriteLine(masyvas[0] + masyvas[1] + masyvas[2] + masyvas[3] + masyvas[4]);
            Console.WriteLine(masyvas[4] + masyvas[3] + masyvas[2] + masyvas[1] + masyvas[0]);
        }

        static string[] Input(int i = 0)
        {
            string[] masyvas = new string[5];
            do
            {

                Console.Write("Įveskite skaičių:");
                masyvas[i] = Convert.ToString(Console.ReadLine());
                i++;

            } while (i < 5);

            return masyvas;
        }
            
    }
}