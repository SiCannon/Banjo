using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbSet<Note> Notes { get { return db.Notes; } }

        public UnitOfWork()
        {
            db = new BanjoContext();
        }

        BanjoContext db;
    }
}