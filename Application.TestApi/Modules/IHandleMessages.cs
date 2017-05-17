namespace Application.TestApi.Modules
{
    public interface IHandleMessages
    {
        string HandleResponse(string request, ConfigureModel configuration);
    }
}