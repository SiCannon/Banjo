using System.Collections.Generic;
using Banjo.Website.Model;
using Banjo.Website.ServiceBase;

namespace Banjo.Website.ServiceInterface
{
    public interface INodeService : IGenericService<Node>
    {
        IEnumerable<Node> GetRootNodes();
        IEnumerable<Node> GetChildNodes(int parentNodeId);
    }
}
