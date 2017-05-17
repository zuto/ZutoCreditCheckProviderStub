namespace Application.TestApi.Modules
{
    public interface IRetriever
    {
        IPersistable Get(string forEnvironment, string provider);
    }
}