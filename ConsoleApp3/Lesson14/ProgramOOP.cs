using System;
using ConsoleApp3.Lesson14;

namespace ConsoleApp3
{
    class ProgramOOP

    {
        static void Main()
        {
            Human boss = new Human("Vytautas");
            Company company = new Company(boss, "MyCompany");

            company.OfficePet = new Dog("Doggo");

            company.HireWorker(new Worker("Valytojas Jonas", 460));
            company.HireWorker(new Worker("Programuotojas Zilvinas", 2500));

            company.AddClient(new Client("Kestas"));
            company.AddClient(new Client("Ona"));

            //company.PrintInfo();

            Console.ReadKey();
        }

    }
}
