using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BookDAO
    {
        private SqlConnection sqlConnection;

        public BookDAO()
        {
            string configurationString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(configurationString);
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "SELECT * FROM Books"))
            {
                SqlDataReader sqlDataReader = databaseCommand.Run();

                while (sqlDataReader.Read())
                {
                    books.Add(ReadBook(ref sqlDataReader));
                }
            }

            return books;
        }

        public Book GetById(int customerId)
        {
            Book book = null;

            using (DatabaseCommand databaseCommand = new DatabaseCommand(ref sqlConnection, "SELECT * FROM Books WHERE Id = @Id"))
            {
                databaseCommand.sqlCommand.Parameters.AddWithValue("@Id", customerId);
                SqlDataReader sqlDataReader = databaseCommand.Run();

                if (sqlDataReader.Read())
                {
                    book = ReadBook(ref sqlDataReader);
                }
            }

            return book;
        }

        private Book ReadBook(ref SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string title = (string)reader["title"];
            string author = (string)reader["author"];

            return new Book(id, title, author);
        }
    }
}
