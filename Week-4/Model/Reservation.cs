using System;

namespace Model
{
    public class Reservation
    {
        public int Id { get; }
        public Book Book { get; }
        public Customer Customer { get; }
        public DateTime Creation { get; }

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Book = book;
            Customer = customer;
            Creation = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[Reservation] id: {Id} | Book ID: ({Book.Id}) | Customer ID: ({Customer.Id})";
        }
    }
}
