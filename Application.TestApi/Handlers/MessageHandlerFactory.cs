using System;
using System.Collections.Generic;
using System.Linq;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class MessageHandlerFactory : IMessageHandlerFactory
    {
        private readonly IEnumerable<IHandleDefaultMessages> _defaultMessageHandlers;

        public MessageHandlerFactory(IEnumerable<IHandleDefaultMessages> defaultMessageHandlers)
        {
            _defaultMessageHandlers = defaultMessageHandlers ?? new List<IHandleDefaultMessages>();
        }

        public IHandleMessages GetHandler(string readStream, string provider)
        {
            var messageType = GetMessageType(readStream);
            return _defaultMessageHandlers.Single(h => h.Supports(messageType));
        }

        private Messages GetMessageType(string readStream)
        {
            if (IsEquifaxV2Message(readStream))
            {
                return Messages.Equifax;
            }

            if (IsEquifaxV4Message(readStream))
            {
                return Messages.EquifaxV4Quotation;
            }

            if (IsEquifaxPasswordReset(readStream))
            {
                return Messages.EquifaxPasswordReset;
            }

            if (IsEquifaxLogonRequest(readStream))
            {
                return Messages.EquifaxLogonRequest;
            }

            if (IsEquifaxChangeSecretRequest(readStream))
            {
                return Messages.EquifaxChangeSecretRequest;
            }

            throw new ArgumentOutOfRangeException(nameof(readStream),
                "The passed in message does not match accepted message types: "
                + readStream);
        }

        private static bool IsEquifaxV2Message(string readStream)
        {
            return readStream.Contains("v2/creditsearch/creditquotationsearchrequest");
        }

        private static bool IsEquifaxV4Message(string readStream)
        {
            return readStream.Contains("v4/creditsearch/creditquotationsearchrequest");
        }

        private static bool IsEquifaxPasswordReset(string readStream)
        {
            return readStream.Contains("changePasswordRequest");
        }

        private static bool IsEquifaxLogonRequest(string readStream)
        {
            return readStream.Contains("logonrequest");
        }

        private bool IsEquifaxChangeSecretRequest(string readStream)
        {
            return readStream.Contains("v4/changeclientsecret/changeclientsecretrequest");
        }
    }
}