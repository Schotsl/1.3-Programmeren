using System;
using Model;
using DAL;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            BookDAO bookDAO = new BookDAO();
            CustomerDAO customerDAO = new CustomerDAO();
            ReservationDAO reservationDAO = new ReservationDAO();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All customers:");
            Console.ResetColor();

            foreach (Customer customer in customerDAO.GetAll())
            {
                Console.WriteLine(customer);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAll books:");
            Console.ResetColor();

            foreach (Book book in bookDAO.GetAll())
            {
                Console.WriteLine(book);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAll reservations:");
            Console.ResetColor();

            foreach (Reservation reservation in reservationDAO.GetAll())
            {
                Console.WriteLine(reservation);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nBook search:");
            Console.ResetColor();

            foreach (Customer customer in reservationDAO.GetByBookId(1))
            {
                Console.WriteLine(customer);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCustomer search:");
            Console.ResetColor();

            foreach (Book book in reservationDAO.GetByCustomerId(1))
            {
                Console.WriteLine(book);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSimple search:");
            Console.ResetColor();

            Console.WriteLine(customerDAO.GetById(1));
            Console.WriteLine(bookDAO.GetById(1));

            Console.ReadKey();
        }
    }
}
