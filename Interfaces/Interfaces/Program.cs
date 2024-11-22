﻿using Interfaces.Entities;
using System.Globalization;
using Interfaces.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data");
        Console.Write("Car Model: ");
        string model = Console.ReadLine();

        Console.Write("Pickup: ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return: ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter price per day");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("Invoice");
        Console.WriteLine(carRental.Invoice);
    }
}