using System;
using Application.TestApi.Entities;

namespace Application.TestApi.DataAccess
{
    public class PersistStuff : IPersistStuff
    {
        private readonly ITransactionFactory _transactionFactory;
        private readonly IQueryRunner _queryRunner;

        public PersistStuff(ITransactionFactory transactionFactory, IQueryRunner queryRunner)
        {
            _transactionFactory = transactionFactory;
            _queryRunner = queryRunner;
        }

        public IPersistable Save(ConfigureModel toSave)
        {
            using (var transaction = _transactionFactory.StartTransaction())
            {
                _queryRunner.CreateOrUpdateProviderConfiguration(transaction, toSave);
                transaction.Commit();
            }
            return toSave;
        }

        public T Get<T>(string forProvider, string forEnvironment) where T : IPersistable
        {
            using (var transaction = _transactionFactory.StartTransaction())
            {
                return (T)Convert.ChangeType(_queryRunner.GetConfiguration(transaction, forProvider, forEnvironment), typeof(T));
            }
        }
    }
}