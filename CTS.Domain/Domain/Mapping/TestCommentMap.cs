using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain.Mapping
{
    public class TestCommentMap : EntityTypeConfiguration<TestComment>
    {
        public TestCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TestItemId)
                .IsRequired();
                

            // Properties
            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(2000);


            this.Property(t => t.IsHtml);

            this.Property(t => t.CommentedBy).HasMaxLength(100);
            this.Property(t => t.CommentedDate);

            this.HasRequired(t => t.TestItem)
                .WithMany(t => t.TestComments)
                .HasForeignKey(d => d.TestItemId);
        }
    }
}
