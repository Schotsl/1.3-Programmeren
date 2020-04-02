using System;
using System.Globalization;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // Create customer
            Customer customer = new Customer("Sjors", DateTime.Parse("2000-03-22 16:10:31"));
            printCustomer(customer);

            // Create ticket
            Ticket ticket = new Ticket("Shrek", 10, DateTime.Parse("2020-03-30 20:00:00"), 3, 6);

            // Create reservation and add customer and tickets
            Reservation reservation = new Reservation(customer);
            reservation.tickets.Add(ticket);

            // Console log the total price
            string total = reservation.Total.ToString("#.00", CultureInfo.InvariantCulture);
            Console.WriteLine($"Total price of reservation: {total} €");
        }

        void printCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(customer.Name);
            Console.ResetColor();

            Console.WriteLine($"Date of birth: {customer.Birth}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Date of registration: {customer.Signup}");
            Console.WriteLine($"Discount: {customer.Discount}\n");
        }
    }
}
