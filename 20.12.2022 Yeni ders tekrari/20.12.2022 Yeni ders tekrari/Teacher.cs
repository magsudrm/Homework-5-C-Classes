using System;
using System.Collections.Generic;
using System.Text;

namespace _20._12._2022_Yeni_ders_tekrari
{
    internal class Teacher:Human 
    {
        public Teacher(string name,string surname,string subject) : base(name,surname)
        {
            this.Subject = subject;
        }
        public string Subject;
    }
}
