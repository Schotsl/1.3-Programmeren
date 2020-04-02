using System;

namespace Opdracht_1
{
    class Book
    {
        public int Amount
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public string Author
        {
            get;
        }

        public double Total
        {
            get { return Price * Amount; }
        }

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Price = price;
            this.Author = author;
        }

        public virtual void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {Author}, {Price} (x{Amount})");
        }
    }
}
