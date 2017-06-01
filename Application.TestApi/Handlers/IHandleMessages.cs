using Application.TestApi.Entities;

namespace Application.TestApi.Handlers
{
    public interface IHandleMessages
    {
        string HandleResponse(string request, ConfigureModel configuration);
    }
}