using System.Collections.Generic;
using System.Linq;
using Banjo.Website.Database;
using Banjo.Website.Model;
using Banjo.Website.ServiceBase;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Service
{
    public class NodeService : GenericService<Node>, INodeService
    {
        public NodeService(IBanjoContext database) : base(database)
        {
        }

        public Node GetRootNode()
        {
            return database.Nodes.SingleOrDefault(x => x.ParentNodeId == null);
        }

        public IEnumerable<Node> GetChildNodes(int parentNodeId)
        {
            return database.Nodes.Where(x => x.ParentNodeId == parentNodeId);
        }
    }
}