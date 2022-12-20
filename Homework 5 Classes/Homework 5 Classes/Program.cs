using System;

namespace Homework_5_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-2
            Console.WriteLine("Elave etmek istediyiniz benzin miqdarini daxil edin");
            int oilInput = converted();
            Car car1 = new Car ( "Lexus", "Lx570", 19000, 120, 30 );
            Console.WriteLine(car1.AddFuel(oilInput));



            // Task-3
            Console.WriteLine("Sayi daxil edin");
            int arrLength =converted();
            Employee[] employees = new Employee[arrLength];
            for (int i = 0; i < arrLength; i++) 
            {
                Console.WriteLine(i + "Employee fullname");
                string input1Str=Console.ReadLine();

                Console.WriteLine(i + "Employee age");
                int input2 = converted();

                Console.WriteLine(i + "Employee salary");
                int input3=converted();

                Console.WriteLine(i + "Employee position");
                string input4Str=Console.ReadLine();

                employees[i] = new Employee(input1Str, input2, input3, input4Str);
            }

            // Elave-Task
            Console.WriteLine("Axtaris etmek isteyirsinizmi?  y or n");
            bool yesOrnot = false;
            do
            {
                var decision = Console.ReadLine();
                if (decision != "y" && decision != "n")
                {
                    Console.WriteLine("Input y ve n dan ferqli ola bilmez.Yeniden daxil edin");
                    yesOrnot = true;
                }
                else if (decision == "n")
                {
                    Console.WriteLine("Proses bitdi");
                }
                else if (decision == "y")
                {
                    yesOrnot = false;
                }
            } while (yesOrnot==true);

            Console.WriteLine("Axtarmaq istediyiniz melumatlari daxil edin");
            var search = Console.ReadLine();
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].FullName.Contains(search))
                {
                    Console.WriteLine($" Fullname: " + employees[i].FullName + " Age: " + employees[i].Age + " Salary: " + employees[i].Salary + " Position: " + employees[i].Position);
                }
                else
                    Console.WriteLine("Axtardiginiz melumatlara uygun employee yoxdur");
            }


        }
        static int converted()
        {
            string inputstr=Console.ReadLine();
            int input=Convert.ToInt32(inputstr);
            return input;
        }
    }
}
