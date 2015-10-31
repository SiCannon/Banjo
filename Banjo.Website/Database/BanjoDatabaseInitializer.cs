using System.Data.Entity;
using Banjo.Website.Model;

namespace Banjo.Website.Database
{
    public class BanjoDatabaseInitializer_Always : DropCreateDatabaseAlways<BanjoContext>
    {
        protected override void Seed(BanjoContext context)
        {

        }
    }

    public class BanjoDatabaseInitializer_WhenChanged : DropCreateDatabaseIfModelChanges<BanjoContext>
    {
        protected override void Seed(BanjoContext context)
        {

        }
    }

    public class TestData
    {
        public static void Populate(BanjoContext db)
        {
            db.Nodes.Add(new Node
            {
                Text = "Work"
            });
            db.Nodes.Add(new Node
            {
                Text = "Films"
            });
            db.Nodes.Add(new Node
            {
                Text = "Flat"
            });
            db.Nodes.Add(new Node
            {
                Text = "Company"
            });
            db.Nodes.Add(new Node
            {
                Text = "Holiday"
            });
        }
    }
}