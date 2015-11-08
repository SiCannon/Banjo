using Banjo.Website.Database;

namespace Banjo.Website.ServiceBase
{
    public class BaseService
    {
        protected IBanjoContext database;

        public BaseService(IBanjoContext database)
        {
            this.database = database;
        }
    }
}