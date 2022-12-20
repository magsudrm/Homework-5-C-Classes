using System;
using System.Collections.Generic;
using System.Text;

namespace _20._12._2022_Yeni_ders_tekrari
{
    internal class Student : Human
    {
        public Student(string name) : base(name)
        {
        }
        public Student(string name,string surname) : base(name,surname)
        {
        }
        public int AvrgPoint;
        public string GroupNo;


    }
}
