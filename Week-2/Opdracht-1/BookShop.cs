using System;
using System.Collections.Generic;

namespace Opdracht_1
{
    class BookShop
    {
        private List<Book> books;

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
            double totalPrice = 0;

            foreach (Book book in books)
            {
                totalPrice += book.price;
            }

            Console.WriteLine($"Total book price: {Math.Round(totalPrice, 2)}");
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
