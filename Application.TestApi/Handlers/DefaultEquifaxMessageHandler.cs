using System;
using Application.TestApi.Entities;
using Application.TestApi.Mocks;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class DefaultEquifaxMessageHandler : IHandleDefaultMessages
    {
        private readonly IEquifaxMockResponseFactory _equifaxEquifaxMockResponseFactory;

        public DefaultEquifaxMessageHandler(IEquifaxMockResponseFactory equifaxEquifaxMockResponseFactory)
        {
            _equifaxEquifaxMockResponseFactory = equifaxEquifaxMockResponseFactory;
        }

        public string HandleResponse(string request, ConfigureModel configuration)
        {
            configuration.Sleep();

            if (configuration.ThrowStackTrace)
            {
                throw new Exception("You are FooBared");
            }

            if (configuration.ThrowFaultException)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.FaultException)
                    .Build();
            }
            
            if (configuration.ThrowValidationFaultException)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.ValidationFaultException)
                    .Build();
            }

            if (configuration.NoTrace)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.NoTrace)
                    .Build();
            }

            if (configuration.NoMatch)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.NoMatch)
                    .Build();
            }

            if (configuration.SingleMatch)
            {
                return _equifaxEquifaxMockResponseFactory
                    .SetRequest(request)
                    .ResponseOfType(EquifaxResponseType.SingleMatch)
                    .OverrideDefaultApplicant()
                    .OverrideScores(configuration)
                    .Build();
            }

            if (configuration.MultipleMatch)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.MultipleMatch)
                    .Build();
            }

            throw new Exception("No option has been configured in the stub. Please select an option and try again.");
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.Equifax;
        }
    }
}