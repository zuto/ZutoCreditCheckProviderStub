using System;
using Application.TestApi.Errors;
using Nancy;

namespace Application.TestApi.Modules
{
    public class BaseHandlerModule : NancyModule
    {
        private readonly IRetriever _readonlyRepository;

        public BaseHandlerModule(IRetriever readonlyRepository)
        {
            _readonlyRepository = readonlyRepository;
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
        }
    }

    public class ConfigData
    {
        public ConfigData(ConfigureModel configureModel)
        {
            
        }
    }

    public class ConfigureModel : IPersistable
    {
        public string Id { get; set; }
        public string Provider { get; set; }
        public string ForEnvironment { get; set; }

        public IPersistable Save(IPersistStuff persister)
        {
            return null;
        }
    }
}