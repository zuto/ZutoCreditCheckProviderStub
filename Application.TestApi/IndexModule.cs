using System.Globalization;
using System.Net;
using System.Threading;
using System.Web;
using Nancy;
using Nancy.Diagnostics;
using Nancy.IO;

namespace Application.TestApi
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/GetData"] = parameters => Response.AsText(Respond("Here is Data"));

            Post["/PostData"] = parameters => Response.AsText(RespondToPost(Request.Body));

            Post["/SetTimer/{timeout?0}"] = parameters => Response.AsText(SetTimeOut((int)parameters.timeout));

            Get["/GetRequestCount"] = parameters => Response.AsText(Respond(HttpContext.Current.Cache.Get("RequestRecieved") == null ? null : HttpContext.Current.Cache.Get("RequestRecieved").ToString()));
        }



        private string SetTimeOut(int timeout)
        {
            HttpContext.Current.Cache.Remove("Timeout");
            HttpContext.Current.Cache.Insert("Timeout", timeout);
            return timeout.ToString(CultureInfo.InvariantCulture);
        }

        private string RespondToPost(RequestStream body)
        {
            var getRequestRecieved = HttpContext.Current.Cache.Get("RequestRecieved") == null ? 0 : int.Parse(HttpContext.Current.Cache.Get("RequestRecieved").ToString());
            IncrementCount(getRequestRecieved);
            int sleepTime = HttpContext.Current.Cache.Get("Timeout") == null ? 0 : int.Parse(HttpContext.Current.Cache.Get("Timeout").ToString());
            Thread.Sleep(sleepTime);
            return "Received Post";
        }

        private void IncrementCount(int getRequestRecieved)
        {
            HttpContext.Current.Cache.Remove("RequestRecieved");
            getRequestRecieved++;
            HttpContext.Current.Cache.Insert("RequestRecieved", getRequestRecieved);
        }

        private string Respond(string returnString)
        {
            Thread.Sleep(6000);
            return returnString;
        }
    }
}