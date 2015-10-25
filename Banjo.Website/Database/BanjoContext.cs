using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class BanjoContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        static BanjoContext()
        {
            System.Data.Entity.Database.SetInitializer<BanjoContext>(new BanjoDatabaseInitializer_WhenChanged());
        }
    }
}