using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.TestApi.DataAccess
{
    public interface IDapperQueryRunner
    {
        IEnumerable<TValue> Get<TValue>(ICommandDefinition<TValue> query) where TValue : DapperEntity;

        TValue Query<TValue>(ICommandDefinition<TValue> query);
    }
}