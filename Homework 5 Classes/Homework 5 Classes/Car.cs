using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_Classes
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;

        public Car(string brand, string model, int millage, int fuelcapasity, int currentfuel) : base(brand, model, millage)
        {
            FuelCapacity = fuelcapasity;
            CurrentFuel = currentfuel;
        }

        public bool AddFuel(int fuel)
        {
            if (CurrentFuel + fuel <= FuelCapacity)
            {
                return true;
            }
            return false;
        }


    }
}
