using ConsoleApp3.Lesson8.House;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program8
    {
        static void Main(string[] args)
        {
            House house = new House("black", "yellow", "red");

            Console.WriteLine($"{house.Door} + {house.FrontDoor}");

            house.OpenDoor();



           //  House testHouse = new House("black", "yellow", "red");
        }
    }
}
