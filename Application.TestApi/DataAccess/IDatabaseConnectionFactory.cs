using System.Data;

namespace Application.TestApi.DataAccess
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}