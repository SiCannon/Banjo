using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
}