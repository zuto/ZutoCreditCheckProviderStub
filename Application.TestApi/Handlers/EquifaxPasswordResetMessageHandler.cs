using System;
using Application.TestApi.DataAccess;
using Application.TestApi.Entities;
using Application.TestApi.Mocks;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class EquifaxPasswordResetMessageHandler : IHandleDefaultMessages
    {
        private readonly IEquifaxMockResponseFactory _equifaxEquifaxMockResponseFactory;

        public EquifaxPasswordResetMessageHandler(
            IEquifaxMockResponseFactory equifaxEquifaxMockResponseFactory)
        {
            _equifaxEquifaxMockResponseFactory = equifaxEquifaxMockResponseFactory;
        }

        public string HandleResponse(string request, ConfigureModel configuration)
        {
            return _equifaxEquifaxMockResponseFactory.ResponseOfType(EquifaxResponseType.PasswordReset).Build();
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.EquifaxPasswordReset;
        }
    }
}