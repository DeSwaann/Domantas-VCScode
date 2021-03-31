using System;

namespace ConsoleApp3
{
    class Homework1
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pažymį: ");
            int pazymys = Convert.ToInt32(Console.ReadLine());
            if (pazymys<=10 && pazymys>=1) // vietoje AND  galima sukurti papildom1 if viduje atskirai tikrinantį antrą salygą
            { 
                if (pazymys == 10)
                {
                    Console.WriteLine("Įvertinimas: puiku");
                }
                else if (pazymys >= 8)
                {
                    Console.WriteLine("Įvertinimas: labai gerai");
                }
                else if (pazymys >= 6)
                {
                    Console.WriteLine("Įvertinimas: gerai");
                }
                else if (pazymys == 5)
                {
                    Console.WriteLine("Įvertinimas: vidutiniškai");
                }
                else if (pazymys == 4)
                {
                    Console.WriteLine("Įvertinimas: bent teigiamas");
                }
                else if (pazymys < 4)
                {
                    Console.WriteLine("Įvertinimas: labai blogai");
                }
                
            } else
            {
                Console.WriteLine("Neteisinga įvestis");
            }
        }
    }
}
