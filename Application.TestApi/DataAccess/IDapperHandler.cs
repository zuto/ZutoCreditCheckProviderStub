using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.TestApi.DataAccess
{
    public interface IDapperHandler
    {
        IEnumerable<TValue> Query<TValue>(Dapper.CommandDefinition command);
        TValue ExecuteScalar<TValue>(Dapper.CommandDefinition command);
    }
}