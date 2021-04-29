using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson14
{
    sealed class Worker : Human
    {
        private int _salary;
        private int workerList;

        public int GetSalary()
        {
            return _salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }
        public Worker(string name, int salary) : base (name)
        {
            _salary = salary;
        }
    }
}
