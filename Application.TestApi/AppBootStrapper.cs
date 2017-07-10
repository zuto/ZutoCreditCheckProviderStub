using Application.TestApi.CreditRequestParser;
using Application.TestApi.Errors;
using Application.TestApi.Handlers;
using Application.TestApi.Modules;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Application.TestApi
{
    public class AppBootStrapper : DefaultNancyBootstrapper
    {
        protected override void RequestStartup(TinyIoCContainer requestContainer, IPipelines pipelines,
            NancyContext context)
        {
            pipelines.OnError.AddItemToEndOfPipeline((ctx, ex) => ErrorResponse.FromException(ex));
            base.RequestStartup(requestContainer, pipelines, context);
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register<IEquifaxRequestParser, EquifaxRequestParser>();
            container.RegisterMultiple<IHandleDefaultMessages>(new[]
            {
                typeof(DefaultEquifaxMessageHandler)
            });
        }
    }
}