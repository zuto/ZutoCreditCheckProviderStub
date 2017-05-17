namespace Application.TestApi.Modules
{
    public interface IPersistStuff
    {
        IPersistable Save(IPersistable toSave);
        IPersistable Load<T>(string id) where T : IPersistable;
        T Get<T>(string forProvider, string forEnvironment) where T : IPersistable;
    }
}