using System.Data;
using System.Threading.Tasks;
using Application.TestApi.Entities;
using Application.TestApi.Modules;

namespace Application.TestApi.DataAccess
{
    public interface IQueryRunner
    {
        ConfigureModel GetConfiguration(IDbTransaction transaction, string provider, string forEnvironment);
        void CreateOrUpdateProviderConfiguration(IDbTransaction transaction, ConfigureModel forEnvironment);
    }
}