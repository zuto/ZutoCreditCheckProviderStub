using System.Linq;
using Nancy;

namespace Application.TestApi.Home
{
    public class Module : NancyModule
    {
        public Module()
        {
            Get["/"] = parameters => "Shabba " + Request.Headers["X-Forwarded-Proto"].FirstOrDefault();
        }
    }
}