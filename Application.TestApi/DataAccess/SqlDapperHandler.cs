using System.Collections.Generic;
using Dapper;

namespace Application.TestApi.DataAccess
{
    public class SqlDapperHandler : IDapperHandler
    {
        public IEnumerable<TValue> Query<TValue>(CommandDefinition command)
        {
            return command.Transaction.Connection.Query<TValue>(command);
        }

        public TValue ExecuteScalar<TValue>(CommandDefinition command)
        {
            return command.Transaction.Connection.ExecuteScalar<TValue>(command);
        }

    }
}