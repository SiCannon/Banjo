using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class BanjoDatabaseInitializer_Always : DropCreateDatabaseAlways<BanjoContext>
    {
        protected override void Seed(BanjoContext context)
        {
            TestData.Populate(context);
        }
    }

    public class BanjoDatabaseInitializer_WhenChanged : DropCreateDatabaseIfModelChanges<BanjoContext>
    {
        protected override void Seed(BanjoContext context)
        {
            TestData.Populate(context);
        }
    }

    public class TestData
    {
        public static void Populate(BanjoContext db)
        {
            var root = new Node { Text = "Root" };
            var child1 = new Node { Text = "One", ParentNode = root };
            var child2 = new Node { Text = "Two", ParentNode = root };
            var child3 = new Node { Text = "Three", ParentNode = root };

            db.Nodes.Add(root);
            db.Nodes.Add(child1);
            db.Nodes.Add(child2);
            db.Nodes.Add(child3);

            /*db.Nodes.Add(new Node { Text = "Work" });
            db.Nodes.Add(new Node { Text = "Films" });
            db.Nodes.Add(new Node { Text = "Flat" });
            db.Nodes.Add(new Node { Text = "Company" });
            db.Nodes.Add(new Node { Text = "Holiday" });*/

            db.SaveChanges();
        }
    }
}