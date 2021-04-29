using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson14
{
    class Company
    {
        private Human _boss;
        private string _name;
        private List<Client> clientList = new List<Client>();
        private List<Worker> workerList = new List<Worker>();

        public void AddClient(Client newClient)
        {

        }
        public Company (Human boss, string name)
        {
            _boss = boss;
        }

        public Pet OfficePet { get; set; }


        public void FireWorker(Worker fireWorker)
        {
            workerList.Remove(fireWorker);
        }
        public void HireWorker(Worker hireWorker)
        {
            workerList.Add(hireWorker);
        }
        public void PrintAllClients()
        {
            foreach(var element1 in clientList)
            {
                Console.WriteLine(element1);
            }
        }
        public void PrintAllWorkers()
        {
            foreach (var element2 in workerList)
            {
                Console.WriteLine(element2);
            }
        }


    }
}
