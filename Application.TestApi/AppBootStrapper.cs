
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Application.TestApi
{
    public class AppBootStrapper :DefaultNancyBootstrapper
    {
        protected override void RequestStartup(TinyIoCContainer requestContainer, IPipelines pipelines, NancyContext context)
        {
            base.RequestStartup(requestContainer, pipelines, context);
        }
         
    }
}