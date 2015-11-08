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
            var work = new Node { Text = "Work", ParentNode = root };
            var flat = new Node { Text = "Flat", ParentNode = root };
            var letting = new Node { Text = "Letting", ParentNode = flat };
            var company = new Node { Text = "Company", ParentNode = root };

            db.Nodes.Add(root);
            db.Nodes.Add(work);
            db.Nodes.Add(flat);
            db.Nodes.Add(letting);
            db.Nodes.Add(company);

            /*db.Nodes.Add(new Node { Text = "Work" });
            db.Nodes.Add(new Node { Text = "Films" });
            db.Nodes.Add(new Node { Text = "Flat" });
            db.Nodes.Add(new Node { Text = "Company" });
            db.Nodes.Add(new Node { Text = "Holiday" });*/

            db.SaveChanges();
        }
    }
}