using System.Collections.Generic;
using Banjo.Website.Model;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Service
{
    public class NodeService : INodeService
    {
        public IEnumerable<Node> GetNodes()
        {
            return new List<Node>
            {
                new Node { NodeId = 1, Text = "One" },
                new Node { NodeId = 2, Text = "Two" },
                new Node { NodeId = 3, Text = "Three" }
            };
        }
    }
}