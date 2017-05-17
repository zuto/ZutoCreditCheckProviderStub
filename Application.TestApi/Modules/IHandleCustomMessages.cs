namespace Application.TestApi.Modules
{
    public interface IHandleCustomMessages : IHandleMessages
    {
        bool Supports(string provider, Messages messageType);
    }
}