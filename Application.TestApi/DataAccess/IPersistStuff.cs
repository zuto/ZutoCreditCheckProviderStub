using Application.TestApi.Entities;

namespace Application.TestApi.DataAccess
{
    public interface IPersistStuff
    {
        IPersistable Save(ConfigureModel toSave);
        T Get<T>(string forProvider, string forEnvironment) where T : IPersistable;
    }
}