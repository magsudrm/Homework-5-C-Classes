using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_Classes
{
    internal class Employee:Human
    {
        public int Salary;
        public string Position;

        public Employee(string fullname, int age, int salary, string position) : base(fullname, age)
        {
            Salary = salary;
            Position = position;
        }
    }
}
