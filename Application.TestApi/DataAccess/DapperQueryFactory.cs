using System.Data;
using Application.TestApi.Entities;
using Application.TestApi.Modules;
using Dapper;

namespace Application.TestApi.DataAccess
{
    public class DapperQueryFactory : IDapperQueryFactory
    {
        public ICommandDefinition<ConfigureModel> GetConfigureModel(IDbTransaction dbTransaction, string provider,
            string env)
        {
            return new CommandDefinition<ConfigureModel>(@"select TOP 1  p.ID as Id,
                         p.Name as Provider,
                         e.Name as ForEnvironment, 
                         cfg.TimeoutMs as TimeOutMilliSeconds,
                         cfg.StackTrace as ThrowStackTrace,
                         cfg.Exception as ThrowFaultException,
                         cfg.MultipleMatch as MultipleAddressMatch,
                         cfg.NoTrace 
                        as NoTrace from [dbo].[Provider] p
                        inner join [dbo].[Environment] e on p.EnvID = e.ID
                        inner join [dbo].[Configuration] cfg on cfg.ProviderId = p.ID
                         WHERE e.Name = @environment AND p.Name = @provider",
                         new { environment = env, provider },
                         dbTransaction);
        }

        public ICommandDefinition<int> UpsertConfiguration(IDbTransaction dbTransaction, ConfigureModel provider)
        {
            var p = new DynamicParameters();
            p.Add("Environment", provider.ForEnvironment);
            p.Add("Provider", provider.Provider);
            p.Add("TimeOut", provider.TimeOutMilliSeconds);
            p.Add("Exception", provider.ThrowFaultException);
            p.Add("StackTrace", provider.ThrowStackTrace);
            p.Add("NoTrace", provider.NoTrace);
            p.Add("MultipleMatch", provider.ReturnMultipleAddresses);
            return new CommandDefinition<int>("UpsertConfig",
                         p,
                         dbTransaction, CommandType.StoredProcedure);
        }
    }
}