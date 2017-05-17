namespace Application.TestApi.Modules
{
    public class ConfigureModelRepository : IRetriever
    {
        private readonly IPersistStuff _persister;

        public ConfigureModelRepository(IPersistStuff persister)
        {
            _persister = persister;
        }

        public IPersistable Get(string forEnvironment, string provider)
        {
            return _persister.Get<ConfigureModel>(provider, forEnvironment) ?? new ConfigureModel
            {
                Provider = provider.ToLower(),
                ForEnvironment = forEnvironment.ToLower()
            };
        }
    }
}