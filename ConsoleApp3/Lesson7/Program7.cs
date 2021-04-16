using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program7
    {
        static void Main(string[] args)
        {
            /*List<string> aRandomList = new List<string>();
            aRandomList.Add("a random line");
            aRandomList.Insert(1, "a random line2");
            aRandomList.AddRange(aRandomList);
            aRandomList.InsertRange(1, aRandomList);

            Console.WriteLine(aRandomList.Count);
            Console.WriteLine(aRandomList.Contains("a random line"));
            Console.WriteLine(aRandomList.IndexOf("a random line"));
            aRandomList.Remove("a random line");
            aRandomList.RemoveAt(1);
            aRandomList.RemoveRange(0, 2);
            aRandomList.Clear();*/

            Random r = new Random();
            
            List<int> listOfRandomNumbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                int random = r.Next(1, 100);
                listOfRandomNumbers.Add(random);
            }
            listOfRandomNumbers.ForEach(Console.WriteLine);


        }
        
    }

}
