using System;
using System.Collections.Generic;
using ExercicioHeranca.Entity;
using System.Globalization;
namespace ExercicioHeranca
{
    class Program
    {
        static void Main (string [] args){

            List<Employee> listEmp = new List<Employee>();

            Console.Write("Quantity of Employee: ");
            int numberOfEmployee = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfEmployee; i++)
            {
                Console.WriteLine($"Employee Number {i}");
                Console.Write("Outsourced ? (y/n) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'y')
                {
                    Console.Write("Addiotional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listEmp.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    listEmp.Add(new Employee(name, hours, valuePerHours));
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("PAYMENTS: ");
                foreach(Employee emp in listEmp){
                    Console.WriteLine($"Name: {emp.Name} - R$ {emp.Payment()}");

                }
            }
        }
    }
}
