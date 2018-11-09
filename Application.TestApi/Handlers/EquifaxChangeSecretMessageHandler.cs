using Application.TestApi.Entities;
using Application.TestApi.Mocks;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class EquifaxChangeSecretMessageHandler : IHandleDefaultMessages
    {
        private readonly IEquifaxMockResponseFactory _equifaxEquifaxMockResponseFactory;

        public EquifaxChangeSecretMessageHandler(
            IEquifaxMockResponseFactory equifaxEquifaxMockResponseFactory)
        {
            _equifaxEquifaxMockResponseFactory = equifaxEquifaxMockResponseFactory;
        }

        public string HandleResponse(string request, ConfigureModel configuration)
        {
            return _equifaxEquifaxMockResponseFactory.ResponseOfType(EquifaxResponseType.ValidChangeSecretResponse).Build();
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.EquifaxChangeSecretRequest;
        }
    }
}