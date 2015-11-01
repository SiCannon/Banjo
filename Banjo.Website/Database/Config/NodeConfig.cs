using System.Data.Entity.ModelConfiguration;
using Banjo.Website.Model;

namespace Banjo.Website.Database.Config
{
    public class NodeConfig : EntityTypeConfiguration<Node>
    {
        public NodeConfig()
        {
            this.HasOptional(x => x.ParentNode)
                .WithMany(x => x.ChildNodes)
                .HasForeignKey(x => x.ParentNodeId);
        }
    }
}