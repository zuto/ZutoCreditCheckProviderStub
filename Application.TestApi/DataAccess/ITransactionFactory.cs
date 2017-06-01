using System.Data;

namespace Application.TestApi.DataAccess
{
    public interface ITransactionFactory
    {
        IDbTransaction StartTransaction();
    }
}