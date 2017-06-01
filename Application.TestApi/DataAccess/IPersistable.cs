namespace Application.TestApi.DataAccess
{
    public interface IPersistable
    {
        string Id { get; set; }
        IPersistable Save(IPersistStuff persister);
    }
}