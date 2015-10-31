using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbSet<Node> Nodes { get { return db.Nodes; } }

        public UnitOfWork()
        {
            db = new BanjoContext();
        }

        BanjoContext db;
    }
}