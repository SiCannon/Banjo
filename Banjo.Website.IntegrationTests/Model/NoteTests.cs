using System;
using System.Linq;
using Banjo.Website.Database;
using Banjo.Website.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banjo.Website.IntegrationTests.Model
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        public void Can_Save_Node()
        {
            var node = new Node { Text = "Test Note " + DateTime.Now.ToString() };
            using (var db = new BanjoContext())
            {
                db.Nodes.Add(node);
                db.SaveChanges();
                Assert.IsNotNull(node.NodeId);
                Assert.AreNotEqual(0, node.NodeId);
            }

            using (var db = new BanjoContext())
            {
                var savedNode = db.Nodes.SingleOrDefault(x => x.NodeId == node.NodeId);
                Assert.IsNotNull(savedNode);
            }
        }

        [TestMethod]
        public void Can_Save_Children()
        {
            int rootNodeId;
            int childNodeId;

            using (var db = new BanjoContext())
            {
                var rootNode = new Node
                {
                    Text = "Root"
                };
                db.Nodes.Add(rootNode);
                db.SaveChanges();
                rootNodeId = rootNode.NodeId.Value;
            }

            using (var db = new BanjoContext())
            {
                var childNode = new Node
                {
                    Text = "Child",
                    ParentNodeId = rootNodeId
                };
                db.Nodes.Add(childNode);
                db.SaveChanges();
                childNodeId = childNode.NodeId.Value;
            }

            using (var db = new BanjoContext())
            {
                var rootNode = db.Nodes.Single(x => x.NodeId == rootNodeId);
                Assert.IsNotNull(rootNode);
                Assert.IsNotNull(rootNode.ChildNodes);
                Assert.AreEqual(1, rootNode.ChildNodes.Count);

            }
        }

    }
}
