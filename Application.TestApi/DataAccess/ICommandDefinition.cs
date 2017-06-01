namespace Application.TestApi.DataAccess
{
    public interface ICommandDefinition
    {
        Dapper.CommandDefinition Command { get; set; }
    }

    public interface ICommandDefinition<TValue> : ICommandDefinition
    {
    }
}