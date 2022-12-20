using System;
using System.Collections.Generic;
using System.Text;

namespace _20._12._2022_Yeni_ders_tekrari
{
    internal class Human
    {
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, string surname)
        {
            Surname = surname;
            Name = name;
        }
        public string Name;
        public string Surname;
        public int Age=24;

    }
}
