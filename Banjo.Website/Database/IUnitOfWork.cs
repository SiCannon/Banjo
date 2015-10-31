using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public interface IUnitOfWork
    {
        IDbSet<Node> Nodes { get; }
    }
}
