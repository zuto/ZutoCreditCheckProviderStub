namespace Application.TestApi.Modules
{
    public interface IHandleDefaultMessages : IHandleMessages
    {
        bool Supports(Messages messageType);
    }
}