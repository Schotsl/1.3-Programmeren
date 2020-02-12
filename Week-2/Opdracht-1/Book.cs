using System;

namespace Opdracht_1
{
    class Book
    {
        public string title;
        public double price;
        public string author;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.price = price;
            this.author = author;
        }

        public virtual void Print()
        {
            Console.WriteLine($"[Book] '{title}' by {author}, {price}");
        }
    }
}
