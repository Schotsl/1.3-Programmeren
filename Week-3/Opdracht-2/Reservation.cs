using System.Collections.Generic;

namespace Opdracht_2
{
    public class Reservation
    {
        public Customer customer;
        public List<Ticket> tickets;

        public double Total
        {
            get
            {
                double total = 0;

                // Loop over each ticket and if it has a discount give a 5% discount
                tickets.ForEach((ticket) =>
                {
                    double price = ticket.price;

                    if (ticket.Discount)
                    {
                        price = price * 0.95;
                    }

                    total += price;
                });

                // If the signed up more than a year ago give them a 10% discount
                if (customer.Discount)
                {
                    total = total * 0.95;
                }

                return total;
            }
        }

        public Reservation(Customer customer)
        {
            this.customer = customer;
            this.tickets = new List<Ticket>();
        }
    }
}
