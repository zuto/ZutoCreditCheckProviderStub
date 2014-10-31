using Nancy;

namespace Application.TestApi
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/GetData"] = parameters => Response.AsText(
                "Here is Data");

            Post["/PostData"] = parameters => Response.AsText(
               "Data Received");
        }

    }
}