using System;
using System.Data.Entity;
using Banjo.Website.Database.Config;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class BanjoContext : DbContext, IBanjoContext
    {
        public IDbSet<Node> Nodes { get; set; }

        static BanjoContext()
        {
            System.Data.Entity.Database.SetInitializer<BanjoContext>(new BanjoDatabaseInitializer_Always());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new NodeConfig());
        }

        public IDbSet<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public void Added<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Added;
        }

        public void Modified<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void Unchanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Unchanged;
        }

        public void Deleted<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Deleted;
        }
    }
}