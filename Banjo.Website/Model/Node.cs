namespace Banjo.Website.Model
{
    public class Node
    {
        public int? NodeId { get; set; }
        public string Text { get; set; }
        public int? ParentNodeId { get; set; }
        public Node ParentNode { get; set; }
    }
}