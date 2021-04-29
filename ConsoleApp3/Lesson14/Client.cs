using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson14
{
    sealed class Client : Human
    {
        static private int _clientCount = 0;
        private int _clientList;

        public Client(string name) : base(name)
        {
           
        }
        public int ClientID { get; set; }
    }
}
