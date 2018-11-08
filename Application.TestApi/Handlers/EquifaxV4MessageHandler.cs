using System;
using Application.TestApi.Entities;
using Application.TestApi.Mocks;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class EquifaxV4MessageHandler : IHandleDefaultMessages
    {
        private readonly IEquifaxMockResponseFactory _equifaxEquifaxMockResponseFactory;

        public EquifaxV4MessageHandler(IEquifaxMockResponseFactory equifaxEquifaxMockResponseFactory)
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
                    .ResponseOfType(EquifaxResponseType.FaultExceptionV4)
                    .Build();
            } 

            if (configuration.ThrowValidationFaultException)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.ValidationFaultExceptionV4)
                    .Build();
            }

            
            if (configuration.NoTrace)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.NoTraceV4)
                    .Build();
            }

            
            if (configuration.NoMatch)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.NoMatchV4)
                    .Build();
            }
            
            if (configuration.SingleMatch)
            {
                return _equifaxEquifaxMockResponseFactory
                    .SetRequest(request)
                    .ResponseOfType(EquifaxResponseType.SingleMatchV4)
                    .OverrideDefaultApplicant()
                    .OverrideScores(configuration)
                    .Build();
            }
            
            if (configuration.MultipleMatch)
            {
                return _equifaxEquifaxMockResponseFactory
                    .ResponseOfType(EquifaxResponseType.MultipleMatchV4)
                    .Build();
            }

            throw new Exception("No option has been configured in the stub. Please select an option and try again.");
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.EquifaxV4Quotation;
        }
    }
}