using System;
using System.Data;

namespace Application.TestApi.DataAccess
{
    public class CommandDefinition<TReturnType> : ICommandDefinition<TReturnType>
    {
        public CommandDefinition(string commandText, dynamic parameters, IDbTransaction transaction, CommandType commandType = CommandType.Text)
        {
            Command = new Dapper.CommandDefinition(commandText, parameters, transaction, null, commandType);
        }

        public Dapper.CommandDefinition Command { get; set; }
    }
}