using System;
using System.IO;
using System.Web;
using Application.TestApi.Entities;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers.CallCredit
{
    public class DefaultCallCreditMessageHandler : IHandleDefaultMessages
    {
        private static string CallCreditMocksPath =>
            Path.Combine(HttpContext.Current.Server.MapPath("~"), "Mocks/CallCredit");

        public string HandleResponse(string request, ConfigureModel configuration)
        {
            return File.ReadAllText(Path.Combine(CallCreditMocksPath, "ValidResponseWithScore.xml"));
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.CallCredit;
        }
    }
}