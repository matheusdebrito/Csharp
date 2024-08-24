using System;
using System.Globalization;
using EnumeracaoComposicao.Entities.Enums;
using EnumeracaoComposicao.Entities;

namespace EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Mundo!");

            Console.Write("Enter Department Name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter Worker Data: ");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);

            Worker worker = new(name, level, baseSalary, dept);

            Console.Write("How Many Contracts to this Workder? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration: (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name} ");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");





        }
    }
}