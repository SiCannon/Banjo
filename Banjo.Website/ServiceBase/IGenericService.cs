using System.Data.Entity;

namespace Banjo.Website.ServiceBase
{
    public interface IGenericService<TEntity> where TEntity: class
    {
        IDbSet<TEntity> GetAll();
        TEntity Create(TEntity entity, bool commit = true);
        TEntity Update(TEntity entity, bool commit = true);
    }
}
