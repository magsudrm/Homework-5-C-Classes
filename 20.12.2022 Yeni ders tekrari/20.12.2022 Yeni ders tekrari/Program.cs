using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace _20._12._2022_Yeni_ders_tekrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Human("Maqsud");
            var human2 = new Human("Amin", "Israfilzade");

            Student stdudent1 = new Student("Resad")
            {
                Surname = "Abbasov",
                Age = 30,
                AvrgPoint = 55,
                GroupNo = "P111"
            };
            var teacher1 = new Teacher("Elcin","Agayev","Programmer");
            teacher1.Age = 24;
            WarrantyStudent warrantyStudent = new WarrantyStudent("Tural","Memmedov","P222");

            Car car1 = new Car(12);

            car1.Brand = "Lexus";
            car1.Model = "Lx570";
            car1.Year = 2019;

            Train train = new Train();

            train.Brand = "Araz";
            train.Model = "K-121";
            train.VaqonCount = 34;
            train.Year = 1945;

            HybridCar hybridCar = new HybridCar(30);
            ElectroCar electroCar = new ElectroCar();
        }
    }
}
