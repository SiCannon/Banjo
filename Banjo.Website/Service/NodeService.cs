using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Node> GetAllNodes()
        {
            return work.Nodes;
        }

        public IEnumerable<Node> GetRootNodes()
        {
            return work.Nodes.Where(x => x.ParentNodeId == null);
        }

        public IEnumerable<Node> GetChildNodes(int parentNodeId)
        {
            return work.Nodes.Where(x => x.ParentNodeId == parentNodeId);
        }
    }
}