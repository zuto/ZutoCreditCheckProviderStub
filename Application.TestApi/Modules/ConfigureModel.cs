using System.Threading;

namespace Application.TestApi.Modules
{
    public class ConfigureModel : IPersistable, ISleep
    {
        public string Id { get; set; }
        public string Provider { get; set; }
        public string ForEnvironment { get; set; }
        public bool ThrowFaultException { get; set; }
        public bool ThrowStackTrace { get; set; }
        public int TimeOutMilliSeconds { get; set; }

        public IPersistable Save(IPersistStuff persister)
        {
            return persister.Save(this);
        }

        public void Sleep()
        {
            if (TimeOutMilliSeconds > 0)
                Thread.Sleep(TimeOutMilliSeconds);
        }
    }

    public interface ISleep
    {
        void Sleep();
    }
}