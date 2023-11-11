using System;
using System.Globalization;
using ExerciseWorkerContract.Entities;
using ExerciseWorkerContract.Entities.Enums;

namespace ExerciseWorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament name: ");
            string deptnName = Console.ReadLine();
            Console.WriteLine("***Enter worker data***:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department depart = new Department(deptnName);
            Worker worker = new Worker(name, level, salary, depart);

            Console.Write("\nHow many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Durarion (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                Console.WriteLine();
            }

            Console.WriteLine("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));

            Console.WriteLine($"Name:{worker.Name}");
            Console.WriteLine($"Department:{worker.Department.Name}");
            Console.WriteLine($"Incom for {monthAndYear}: {worker.Income(year, month):C}");
        }
    }
}