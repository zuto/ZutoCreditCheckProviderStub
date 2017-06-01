using System;
using System.Linq;
using Nancy;
using Nancy.Responses;

namespace Application.TestApi
{
    public static class NancyExtensions
    {
        public static void RequiresHttps(this INancyModule module, bool redirect, int? httpsPort)
        {
            module.Before.AddItemToEndOfPipeline(RequiresHttps(redirect, httpsPort));
        }

        private static Func<NancyContext, Response> RequiresHttps(bool redirect, int? httpsPort)
        {
            return (ctx) =>
            {
                Response response = null;
                var request = ctx.Request;

                if (string.Equals(request.Headers["X-Forwarded-Proto"].FirstOrDefault(), "https",
                    StringComparison.InvariantCultureIgnoreCase))
                    return response;
                if (!request.Url.IsSecure)
                {
                    if (redirect && request.Method.Equals("GET", StringComparison.OrdinalIgnoreCase))
                    {
                        var redirectUrl = request.Url.Clone();
                        redirectUrl.Port = httpsPort;
                        redirectUrl.Scheme = "https";
                        response = new RedirectResponse(redirectUrl.ToString());
                    }
                    else
                    {
                        response = new Response { StatusCode = HttpStatusCode.Forbidden };
                    }
                }
                return response;
            };
        }

    }
}