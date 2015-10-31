using System.Collections.Generic;
using Banjo.Website.Model;

namespace Banjo.Website.ServiceInterface
{
    public interface INodeService
    {
        IEnumerable<Node> GetNodes();
    }
}
