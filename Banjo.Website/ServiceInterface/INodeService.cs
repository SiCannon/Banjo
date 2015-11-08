using System.Collections.Generic;
using Banjo.Website.Model;
using Banjo.Website.ServiceBase;

namespace Banjo.Website.ServiceInterface
{
    public interface INodeService : IGenericService<Node>
    {
        Node GetRootNode();
        IEnumerable<Node> GetChildNodes(int parentNodeId);
    }
}
