using System.Collections.Generic;
using Banjo.Website.Model;

namespace Banjo.Website.ServiceInterface
{
    public interface INodeService
    {
        IEnumerable<Node> GetAllNodes();
        IEnumerable<Node> GetRootNodes();
        IEnumerable<Node> GetChildNodes(int parentNodeId);
    }
}
