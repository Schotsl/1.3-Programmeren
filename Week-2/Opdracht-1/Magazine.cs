using System;

namespace Opdracht_1
{
    class Magazine : Book
    {
        private DateTime release;

        public Magazine(string title, string author, double price, DateTime release) : base(title, author, price)
        {
            this.release = release;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] '{title}' by {author}, {price}");
        }
    }
}
