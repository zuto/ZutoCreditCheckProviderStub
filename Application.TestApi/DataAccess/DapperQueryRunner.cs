using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.TestApi.DataAccess
{
    public class DapperQueryRunner : IDapperQueryRunner
    {
        private readonly IDapperHandler _dapperHandler;

        public DapperQueryRunner(IDapperHandler dapperHandler)
        {
            _dapperHandler = dapperHandler;
        }

        public IEnumerable<TValue> Get<TValue>(ICommandDefinition<TValue> query)
            where TValue : DapperEntity
        {
            return _dapperHandler.Query<TValue>(query.Command);
        }

        public TValue Query<TValue>(ICommandDefinition<TValue> query)
        {
            return _dapperHandler.ExecuteScalar<TValue>(query.Command);
        }
    }
}