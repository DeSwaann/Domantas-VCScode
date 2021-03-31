
            using System;

namespace ConsoleApp3
    {
        class Program2
        {
            static void Main(string[] args)
            {
            /* Console.Write("Įveskite vardą: ");
            string myName = (Console.ReadLine());
            Console.Write("Įveskite pavardę: ");
            string myName2 = (Console.ReadLine());
            Console.WriteLine(myName + " " + myName2);

            Console.Write("Įrašykite vardą: ");
            string vardas= Convert.ToString(Console.ReadLine());
            Console.Write("Įrašykite spalvos pirmą raidę: ");
            char raide= Convert.ToChar(Console.ReadLine());
            Console.Write("Įrašykite skaičių: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įrašykite antrą skaičių: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 


            Console.Write("Įveskite apskritimo spindulį: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Apskritimo ilgis yra " + 2*R * 3.14);


            double c = (double) 3600/1000;
            Console.Write("Įveskite atstumą metrais: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite laiką sekundėmis: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greitis: " + a / b * c + "km/h" ); */



            Console.Write("Įveskite amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            
            if (amzius >= 18)
            {
                Console.WriteLine("Jūs esate pilnametis");

            }
            else
            {
                Console.WriteLine("Jūs nesate pilnametis");
            }

            Console.Write("Įveskite amžių: ");
            int amzius2 = Convert.ToInt32(Console.ReadLine());

            

            if (amzius2 % 2 == 1)
            {
                Console.WriteLine("Amžiaus skaitmuo nelyginis");


            }
            else
            {
                Console.WriteLine("amžiaus skaitmuo lyginis");

            }
        }
    }
    }

