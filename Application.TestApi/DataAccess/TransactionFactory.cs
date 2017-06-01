using System.Data;

namespace Application.TestApi.DataAccess
{
    public class TransactionFactory : ITransactionFactory
    {
        private readonly IDatabaseConnectionFactory _databaseConnectionFactory;

        public TransactionFactory(IDatabaseConnectionFactory databaseConnectionFactory)
        {
            _databaseConnectionFactory = databaseConnectionFactory;
        }

        public IDbTransaction StartTransaction()
        {
            return _databaseConnectionFactory.CreateConnection().BeginTransaction();
        }
    }
}