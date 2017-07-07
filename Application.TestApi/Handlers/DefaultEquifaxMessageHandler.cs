using System;
using Application.TestApi.Entities;
using Application.TestApi.Mocks;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class DefaultEquifaxMessageHandler : IHandleDefaultMessages
    {
        public string HandleResponse(string request, ConfigureModel configuration)
        {
            configuration.Sleep();

            if (configuration.ThrowStackTrace)
            {
                EquifaxMocks.ThrowStackTraceException();
            }

            if (configuration.ThrowFaultException)
            {
                return EquifaxMocks.FaultExceptionResponse();
            }

            if (configuration.NoTrace)
            {
                return EquifaxMocks.NoTraceResponse();
            }

            if (configuration.NoMatch)
            {
                return EquifaxMocks.NoMatchResponse();
            }

            if (configuration.SingleMatch)
            {
                return EquifaxMocks.SingleMatchResponse();
            }

            if (configuration.MultipleMatch)
            {
                return EquifaxMocks.MultipleMatchResponse();
            }

            throw new Exception("No option has been configured in the stub. Please select an option and try again.");
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.Equifax;
        }
    }
}