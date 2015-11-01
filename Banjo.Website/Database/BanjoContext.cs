using System.Data.Entity;
using Banjo.Website.Database.Config;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class BanjoContext : DbContext
    {
        public DbSet<Node> Nodes { get; set; }

        static BanjoContext()
        {
            System.Data.Entity.Database.SetInitializer<BanjoContext>(new BanjoDatabaseInitializer_Always());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new NodeConfig());
        }
    }
}