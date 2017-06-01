namespace Application.TestApi.Handlers
{
    public interface IMessageHandlerFactory
    {
        IHandleMessages GetHandler(string readStream, string provider);
    }
}