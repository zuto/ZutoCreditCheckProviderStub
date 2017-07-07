using System.Threading;
using Application.TestApi.DataAccess;

namespace Application.TestApi.Entities
{
    public class ConfigureModel : DapperEntity, IPersistable, ISleep
    {
        public string Id { get; set; }
        public string Provider { get; set; }
        public string ForEnvironment { get; set; }
        public bool ThrowFaultException { get; set; }
        public bool ThrowStackTrace { get; set; }
        public int TimeOutMilliSeconds { get; set; }
        public bool NoTrace { get; set; }
        public bool NoMatch { get; set; }
        public bool SingleMatch { get; set; }
        public bool MultipleMatch { get; set; }

        public IPersistable Save(IPersistStuff persister)
        {
            return persister.Save(this);
        }

        public void Sleep()
        {
            if (TimeOutMilliSeconds > 0)
            {
                Thread.Sleep(TimeOutMilliSeconds);
            }
        }
    }
}