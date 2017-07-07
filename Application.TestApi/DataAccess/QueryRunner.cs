using System.Data;
using System.Linq;
using Application.TestApi.Entities;

namespace Application.TestApi.DataAccess
{
    public class QueryRunner : IQueryRunner
    {
        private readonly IDapperQueryFactory _dapperQueryFactory;
        private readonly IDapperQueryRunner _queryRunner;

        public QueryRunner(IDapperQueryRunner queryRunner, IDapperQueryFactory dapperQueryFactory)
        {
            _queryRunner = queryRunner;
            _dapperQueryFactory = dapperQueryFactory;
        }

        public ConfigureModel GetConfiguration(IDbTransaction transaction, string provider, string forEnvironment)
        {
            var query = _dapperQueryFactory.GetConfigureModel(transaction, provider, forEnvironment);
            var entities = _queryRunner.Get(query);
            return entities.FirstOrDefault();
        }

        public void CreateOrUpdateProviderConfiguration(IDbTransaction transaction, ConfigureModel configureModel)
        {
            var upsertConfiguration = _dapperQueryFactory.UpsertConfiguration(transaction, configureModel);
            _queryRunner.Query(upsertConfiguration);
        }
    }
}