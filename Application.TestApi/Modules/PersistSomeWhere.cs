using System;

namespace Application.TestApi.Modules
{
    public class PersistSomeWhere : IPersistStuff
    {
        public IPersistable Save(IPersistable toSave)
        {
            throw new NotImplementedException();
        }

        public IPersistable Load<T>(string id) where T : IPersistable
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string forProvider, string forEnvironment) where T : IPersistable
        {
            return default(T);
        }
    }
}