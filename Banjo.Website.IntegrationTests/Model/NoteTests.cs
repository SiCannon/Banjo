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

        
    }
}
