namespace Application.TestApi.Modules
{
    public class ConfigureModel : IPersistable
    {
        public string Id { get; set; }
        public string Provider { get; set; }
        public string ForEnvironment { get; set; }

        public IPersistable Save(IPersistStuff persister)
        {
            return null;
        }
    }
}