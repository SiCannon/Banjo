using System.Collections.Generic;

namespace Banjo.Website.Model
{
    public class Node
    {
        public int? NodeId { get; set; }
        public string Text { get; set; }
        public int? ParentNodeId { get; set; }
        public virtual Node ParentNode { get; set; }
        public virtual ICollection<Node> ChildNodes { get; set; }

        public bool HasChildren
        {
            get
            {
                return ChildNodes.Count > 0;
            }
        }
    }
}