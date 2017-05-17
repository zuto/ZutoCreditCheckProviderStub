using System;
using System.IO;
using System.Text;
using Application.TestApi.Errors;
using Nancy;
using Nancy.ModelBinding;

namespace Application.TestApi.Modules
{
    public class BaseHandlerModule : NancyModule
    {
        private readonly IPersistStuff _persister;
        private readonly IRetriever _readonlyRepository;
        private readonly IMessageHandlerFactory _messageHandlerFactory;

        public BaseHandlerModule(IRetriever readonlyRepository, IMessageHandlerFactory messageHandlerFactory, IPersistStuff persister)
        {
            _readonlyRepository = readonlyRepository;
            _messageHandlerFactory = messageHandlerFactory;
            _persister = persister;
            this.RequiresHttps(true, null);
            Get["/{environment?dev}/{provider}"] = parameters =>
            {
                try
                {
                    var model = _readonlyRepository.Get((string)parameters.environment, (string)parameters.provider);

                    var viewModel = new ViewModel
                    {
                        ConfigureModel = model,
                    };

                    return View[viewModel];
                }
                catch (Exception ex)
                {
                    return ErrorResponse.FromException(ex).WithStatusCode(500);
                }
            };
            Post["/{environment?dev}/{provider}"] = parameters =>
            {
                var configureModel = _readonlyRepository.Get(parameters.environment, parameters.provider) as ConfigureModel;

                string contents = Respond(Request.Body, configureModel, parameters.provider);
                var byteArray = Encoding.UTF8.GetBytes(contents);
                var stream = new MemoryStream(byteArray);
                return Response.FromStream(stream, "text/xml; charset=utf-8");

            };
            Post["/{environment?dev}/{provider}/Update"] = parameters =>
            {
                UpdateConfiguration(parameters.provider, parameters.environment);
                return Response.AsRedirect(string.Format("/{0}/{1}", (string)parameters.environment, (string)parameters.provider));
            };
        }

        internal void UpdateConfiguration(string provider, string environment)
        {
            var model = this.Bind<ConfigureModel>();
            model.Provider = provider;
            model.ForEnvironment = environment;
            model.Save(_persister);
        }
        internal string Respond(Stream requestBody, ConfigureModel persistable, string provider)
        {
            var requestXml = new StreamReader(requestBody).ReadToEnd();
            //Hack to Log Xml as Exception.
            new LogEvent(requestXml).Raise();
            Console.WriteLine(requestXml);
            return _messageHandlerFactory.GetHandler(requestXml, provider).HandleResponse(requestXml, persistable);
        }
    }
}