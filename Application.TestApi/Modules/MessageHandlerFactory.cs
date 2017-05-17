using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.TestApi.Modules
{
    public class MessageHandlerFactory : IMessageHandlerFactory
    {
        private readonly IEnumerable<IHandleDefaultMessages> _defaultMessageHandlers;

        public MessageHandlerFactory(IEnumerable<IHandleDefaultMessages> defaultMessageHandlers, IEnumerable<IHandleCustomMessages> customMessageHandlers)
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
            if (IsEquifaxMessage(readStream))
                return Messages.Equifax;
           
            throw new ArgumentOutOfRangeException("readStream", "The passed in message does not match accepted message types: "
                                                                + readStream);
        }

        private bool IsEquifaxMessage(string readStream)
        {
            return readStream.Contains("creditQuotationSearchRequest");
        }
    }
}