using System.Data;
using Application.TestApi.Entities;
using Application.TestApi.Modules;

namespace Application.TestApi.DataAccess
{
    public interface IDapperQueryFactory
    {
        ICommandDefinition<ConfigureModel> GetConfigureModel(IDbTransaction dbTransaction, string provider,
            string env);

        ICommandDefinition<int> UpsertConfiguration(IDbTransaction transaction, ConfigureModel provider);
    }
}