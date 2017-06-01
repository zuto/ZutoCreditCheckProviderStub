using System;
using System.Data;
using System.Data.SqlClient;

namespace Application.TestApi.DataAccess
{
    public class DatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var connectionString = Environment.GetEnvironmentVariable("SQLSERVER_CONNECTION_STRING",EnvironmentVariableTarget.Process);
            var connection =
                new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}