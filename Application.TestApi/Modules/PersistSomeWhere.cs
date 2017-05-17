using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Application.TestApi.Modules
{
    public class PersistSomeWhere : IPersistStuff
    {
        public IPersistable Save(ConfigureModel toSave)
        {
            return toSave;
        }

        public IPersistable Load<T>(string id) where T : IPersistable
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string forProvider, string forEnvironment) where T : IPersistable
        {
            
            var assembly = Assembly.GetExecutingAssembly();
            const string resourceName = "Application.TestApi.Config.dev-equifax.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var config = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                return config;
            }
        }
    }
}