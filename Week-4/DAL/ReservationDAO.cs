using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class ReservationDAO
    {
        private SqlConnection sqlConnection;

        public ReservationDAO()
        {
            string configurationString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(configurationString);
        }

        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "select Reservations.Id as ResId, * from Reservations inner join Customers on Reservations.CustomerId = Customers.id inner join Books on Reservations.BookId = Books.Id"))
            {
                SqlDataReader sqlDataReader = databaseCommand.Run();

                while (sqlDataReader.Read())
                {
                    reservations.Add(ConstructReservation(ref sqlDataReader));
                }
            }

            return reservations;
        }

        public List<Customer> GetByBookId(int bookId)
        {
            List<Customer> customers = new List<Customer>();

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "Select * FROM Reservations inner join Customers on Reservations.Customerid = Customers.id WHERE BookId = @Id"))
            {
                databaseCommand.sqlCommand.Parameters.AddWithValue("@Id", bookId);
                SqlDataReader sqlDataReader = databaseCommand.Run();

                while (sqlDataReader.Read())
                {
                    int id = (int)sqlDataReader["CustomerId"];
                    string firstname = (string)sqlDataReader["FirstName"];
                    string lastname = (string)sqlDataReader["LastName"];
                    string email = (string)sqlDataReader["EmailAddress"];

                    Customer customer = new Customer(id, firstname, lastname, email);

                    customers.Add(customer);
                }                  
            }

            return customers;
        }

        public List<Book> GetByCustomerId(int customerId)
        {
            List<Book> books = new List<Book>();

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "Select * FROM Reservations inner join Books on Reservations.BookId = Books.id WHERE CustomerId = @Id"))
            {
                databaseCommand.sqlCommand.Parameters.AddWithValue("@Id", customerId);
                SqlDataReader sqlDataReader = databaseCommand.Run();

                while (sqlDataReader.Read())
                {
                    int id = (int)sqlDataReader["BookId"];
                    string title = (string)sqlDataReader["Title"];
                    string author = (string)sqlDataReader["Author"];

                    Book book = new Book(id, title, author);

                    books.Add(book);
                }
            }

            return books;
        }

        private Reservation ConstructReservation(ref SqlDataReader sqlDataReader)
        {
            // Construct the book instance
            int bookId = (int)sqlDataReader["BookId"];
            string bookTitle = (string)sqlDataReader["Title"];
            string bookAuthor = (string)sqlDataReader["Author"];
            Book bookInstance = new Book(bookId, bookTitle, bookAuthor);

            // Construct the customer instance
            int customerId = (int)sqlDataReader["CustomerId"];
            string customerFirstname = (string)sqlDataReader["FirstName"];
            string customerLastname = (string)sqlDataReader["LastName"];
            string customerEmail = (string)sqlDataReader["EmailAddress"];
            Customer customerInstance = new Customer(customerId, customerFirstname, customerLastname, customerEmail);

            // Construct and return the reservation instance
            int reservationId = (int)sqlDataReader["ResId"];
            return new Reservation(reservationId, customerInstance, bookInstance);
        }
    }
}
