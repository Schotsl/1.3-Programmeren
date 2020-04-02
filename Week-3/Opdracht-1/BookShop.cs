using System;
using System.Collections.Generic;

namespace Opdracht_1
{
    class BookShop
    {
        private List<Book> books;

        public double TotalPrice
        {
            get { return getTotalPrice(); }
        }

        public BookShop()
        {
            books = new List<Book>();
        }

        public void PrintAllBooks()
        {
            foreach (Book book in books)
            {
                book.Print();
            }
        }

        public void printTotalPrice()
        {
            Console.WriteLine($"Total sales price: {Math.Round(getTotalPrice(), 2)}");
        }

        public double getTotalPrice()
        {
            double totalPrice = 0;

            foreach (Book book in books)
            {
                totalPrice += book.Total;
            }

            return totalPrice;
        }

        public void AddBook(Book newBook)
        {
            Boolean inLibrary = false;

            foreach (Book oldBook in books)
            {
                if (newBook.Author == oldBook.Author && newBook.Title == oldBook.Title)
                {
                    inLibrary = true;
                    oldBook.Amount++;
                }
            }

            if (!inLibrary)
            {
                newBook.Amount = 1;
                books.Add(newBook);
            }
        }
    }
}
