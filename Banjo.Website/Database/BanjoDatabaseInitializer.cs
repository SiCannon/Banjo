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
            db.Notes.Add(new Note
            {
                Text = "Work"
            });
            db.Notes.Add(new Note
            {
                Text = "Films"
            });
            db.Notes.Add(new Note
            {
                Text = "Flat"
            });
            db.Notes.Add(new Note
            {
                Text = "Company"
            });
            db.Notes.Add(new Note
            {
                Text = "Holiday"
            });
        }
    }
}