using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public interface IBanjoContext
    {
        IDbSet<Node> Nodes { get; }

        int SaveChanges();
        IDbSet<TEntity> GetDbSet<TEntity>() where TEntity : class;
        void Added<TEntity>(TEntity entity) where TEntity : class;
        void Modified<TEntity>(TEntity entity) where TEntity : class;
        void Unchanged<TEntity>(TEntity entity) where TEntity : class;
        void Deleted<TEntity>(TEntity entity) where TEntity : class;
    }
}
