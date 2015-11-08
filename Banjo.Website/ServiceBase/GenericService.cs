using System.Data.Entity;
using Banjo.Website.Database;

namespace Banjo.Website.ServiceBase
{
    public class GenericService<TEntity> : BaseService, IGenericService<TEntity> where TEntity : class
    {
        public GenericService(IBanjoContext database) : base(database)
        {

        }

        public IDbSet<TEntity> GetAll()
        {
            return database.GetDbSet<TEntity>();
        }

        public TEntity Create(TEntity entity, bool commit = true)
        {
            database.GetDbSet<TEntity>().Add(entity);

            if (commit)
            {
                database.SaveChanges();
            }

            return entity;
        }

        public TEntity Update(TEntity entity, bool commit = true)
        {
            var set = database.GetDbSet<TEntity>();
            set.Attach(entity);
            database.Modified(entity);

            if (commit)
            {
                database.SaveChanges();
            }

            return entity;
        }

    }
}