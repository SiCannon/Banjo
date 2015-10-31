using System.Collections.Generic;
using Banjo.Website.Database;
using Banjo.Website.Model;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Service
{
    public class NodeService : BaseService, INodeService
    {
        public NodeService(IUnitOfWork work) : base(work)
        {
        }

        public IEnumerable<Node> GetNodes()
        {
            return work.Nodes;
        }
    }
}