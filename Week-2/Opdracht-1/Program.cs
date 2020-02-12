using System;

namespace Opdracht_1
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
            BookShop bookShop = new BookShop();

            bookShop.AddBook(new Book("Heartbreak 101", "Barjan", 69.99));
            bookShop.AddBook(new Book("How to pull the skrt", "Twan", 9.99));
            bookShop.AddBook(new Book("Why I hate JavaScript", "Owen", 10));

            bookShop.AddBook(new Magazine("How to get tan", "Sjors", 4.99, new DateTime()));

            bookShop.PrintAllBooks();
            Console.WriteLine();
            bookShop.printTotalPrice();

            Console.ReadKey();
        }
    }
}
