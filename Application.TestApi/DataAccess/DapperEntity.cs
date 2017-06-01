using Nancy.Json;

namespace Application.TestApi.DataAccess
{
    public abstract class DapperEntity
    {
        public override string ToString()
        {
            return new JavaScriptSerializer().Serialize(this);
        }
    }
}