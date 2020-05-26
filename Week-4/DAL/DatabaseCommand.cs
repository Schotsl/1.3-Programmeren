using System;
using System.Data.SqlClient;

namespace DAL
{
    class DatabaseCommand : IDisposable
    {
        private SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        public DatabaseCommand(ref SqlConnection sqlConnection, string sqlCommand)
        {
            this.sqlConnection = sqlConnection;
            this.sqlCommand = new SqlCommand(sqlCommand, sqlConnection);
        }

        public SqlDataReader Run()
        {
            sqlConnection.Open();
            sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        void IDisposable.Dispose()
        {
            sqlDataReader.Close();
            sqlConnection.Close();
        }
    }
}
