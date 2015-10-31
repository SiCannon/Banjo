using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    interface IUnitOfWork
    {
        IDbSet<Node> Nodes { get; }
    }
}
