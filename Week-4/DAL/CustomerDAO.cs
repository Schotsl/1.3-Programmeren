using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class CustomerDAO
    {
        private SqlConnection sqlConnection;

        public CustomerDAO()
        {
            string configurationString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(configurationString);
        }

        public List<Customer> GetAll()
        {
            List<Customer> books = new List<Customer>();

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "SELECT * FROM Customers"))
            {
                SqlDataReader sqlDataReader = databaseCommand.Run();

                while (sqlDataReader.Read())
                {
                    books.Add(ReadCustomer(ref sqlDataReader));
                }
            }

            return books;
        }

        public Customer GetById(int customerId)
        {
            Customer customer = null;

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "SELECT * FROM Customers WHERE Id = @Id"))
            {
                databaseCommand.sqlCommand.Parameters.AddWithValue("@Id", customerId);
                SqlDataReader sqlDataReader = databaseCommand.Run();

                if (sqlDataReader.Read())
                {
                    customer = ReadCustomer(ref sqlDataReader);
                }
            }

            return customer;
        }

        private Customer ReadCustomer(ref SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string firstname = (string)reader["FirstName"];
            string lastname = (string)reader["LastName"];
            string email = (string)reader["EmailAddress"];

            return new Customer(id, firstname, lastname, email);
        }
    }
}