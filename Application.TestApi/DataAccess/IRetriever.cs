namespace Application.TestApi.DataAccess
{
    public interface IRetriever
    {
        IPersistable Get(string forEnvironment, string provider);
    }
}