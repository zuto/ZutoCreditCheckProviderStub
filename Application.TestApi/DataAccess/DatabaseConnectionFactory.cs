using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Application.TestApi.DataAccess
{
    public class DatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("SQLSERVER_CONNECTION_STRING");
            var connection =
                new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}