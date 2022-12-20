using System;
using System.Collections.Generic;
using System.Text;

namespace _20._12._2022_Yeni_ders_tekrari
{
    internal class Car:Vehicle
    {
        public Car(int fuelCapacity,string brand,string model,int year) : base(brand,model,year)
        {
            this.FuelCapacity = fuelCapacity;
        }
        public Car(int fuelCapacity)
        {
            this.FuelCapacity = fuelCapacity;
        }
        public int FuelCapacity;
    }
}
