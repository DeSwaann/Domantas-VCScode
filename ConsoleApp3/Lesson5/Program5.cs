using System;

namespace ConsoleApp3
{
    class Program5
    {
        static void Main()
        {
            /*Console.WriteLine("Labas...");
            SayHello();
            Console.WriteLine("...viso gero");*/
            //Excersise1();
            //Excersise2();
            //Excersise3();
            Excersise4();

        }

        /* static void SayHello ()
        {
            Console.WriteLine("Hello");
            SaySomething();
        }
        static void SaySomething()
        {
            Console.WriteLine("SaySomething");
            SayBye();
        }
        static void SayBye()
        {
            Console.WriteLine("SayBye"); */

        static void Excersise1()
        {
            Console.Write("Įveskite pirmą sveikąjį skaičių: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą sveikąjį skaičių: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Suma(num1, num2);
            Atimtis(num1, num2);
            Sandauga(num1, num2);
            Dalyba  (num1, num2);
        }
        static void Suma(int temp1 = 1, int  temp2 = 2)
        {
            Console.WriteLine(temp1 + temp2);
            
        }
        static void Atimtis(int temp1 = 1, int temp2 = 2)
        {
            Console.WriteLine(temp1 + temp2);

        }
        static void Sandauga(int temp1 = 1, int temp2 = 2)
        {
            Console.WriteLine(temp1 + temp2);

        }
        static void Dalyba(int temp1 = 1, int temp2 = 2)
        {
            Console.WriteLine(temp1 + temp2);

        }
        static void Excersise2()
        {
            Console.WriteLine(GetText());
        }
        static string GetText()
        {
            int data = 5;
            return "Some text" + data;
        }
        static void Excersise3()
        {
            int indeksas;
            Console.Write("Įveskite svorį kilogramais: ");
            int svoris_kg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite ūgi metrais: ");
            int ugis_m = Convert.ToInt32(Console.ReadLine());

            indeksas = svoris_kg / (ugis_m * ugis_m);
            Console.WriteLine(indeksas);
            Kmi(indeksas);
            Console.WriteLine(Kmi(indeksas));
        }
        static string Kmi(int skaiciavimas)
        {
            string isvada = "";

            if (skaiciavimas < 15)
            {
                isvada = "badaujantis";
             
            }
            else if (skaiciavimas < 5)
            {

            }
                return isvada;
            

        }
        static void Excersise4()
        {

        }

    }


}
