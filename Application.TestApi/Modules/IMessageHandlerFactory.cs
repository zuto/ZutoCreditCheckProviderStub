namespace Application.TestApi.Modules
{
    public interface IMessageHandlerFactory
    {
        IHandleMessages GetHandler(string readStream, string provider);
    }
}