using System;
using System.Collections.Generic;
using System.Text;

namespace _20._12._2022_Yeni_ders_tekrari
{
    internal class WarrantyStudent:Human
    {
        public WarrantyStudent(string name,string surname,string prevGroupNo) : base(name,surname)
        {
            PrevGroupNo = prevGroupNo;
        }
        public string PrevGroupNo;
    }
}
