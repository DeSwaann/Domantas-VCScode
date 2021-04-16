using System;

namespace ConsoleApp3
{
    class Papildoma3
    {
        static void Main(string[] args)
        {
            //Console.Write("Įveskite pirmąjį skaičių: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Įveskite antrąjį skaičių: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Įveskite trečiąjį skaičių: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //var maxValue = Max(num1, num2, num3);
            //Console.WriteLine(maxValue);
            //InRange();

            //var testIfInRange = InRange(num1, num2, num3);
            //Console.WriteLine(testIfInRange);
            //var randomNumber = D20();
            //Console.WriteLine(randomNumber);

            var getInput = TestInput();
            Console.WriteLine(getInput);


        }
        static int Max(int num1, int num2, int num3)
        {
            int maxValue;
            

            if(num1 > num2 && num2 > num3)

            {
                Console.WriteLine("Pirmas numeris didžiausias");
                maxValue = num1;
            }
            else if (num1 < num2 && num2 > num3)
            {
                Console.WriteLine("Antras numeris didžiausias");
                maxValue = num2;
            }
            else
            {
                Console.WriteLine("Trečias numeris didžiausias");
                maxValue = num3;
            }


            return maxValue;
        }
        static bool InRange(int num1, int num2, int num3)
        {
            bool testIfInRange = false;
            if ((num1 < num2 && num1 > num3) || (num1 > num2 && num1 < num3))
            {
                testIfInRange = true;
                Console.WriteLine("Pirmasis numeris yra tarp antrojo ir trečiojo");
            }
            else
            {
                Console.WriteLine("Pirmasis numeris nėra tarp antrojo ir trečiojo");
            }



            return testIfInRange;
        }
        static int D20()
        {

            Random r = new Random();
            int randomNumber = r.Next(0, 20);

            return randomNumber;
        }
        static int TestInput()
        {
            int getInput;
            do
            {
                Console.Write("Įveskite skaičių nuo 10 iki 20: ");
                getInput = Convert.ToInt32(Console.ReadLine());

            }
            while (getInput < 10 || getInput > 20);
           
            return getInput;
        }


    }
}
