namespace Application.TestApi.Modules
{
    public interface IPersistable
    {
        string Id { get; set; }
        IPersistable Save(IPersistStuff persister);
    }
}