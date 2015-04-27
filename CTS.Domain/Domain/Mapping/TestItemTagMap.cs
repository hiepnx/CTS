using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain.Mapping
{
    class TestItemTagMap : EntityTypeConfiguration<TestItemTag>
    {
        public TestItemTagMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TestItemId);
            // Properties
            this.Property(t => t.TagName)
                .IsRequired()
                .HasMaxLength(100);

            this.HasRequired(t => t.TestItem)
                .WithMany(t => t.TestItemTags)
                .HasForeignKey(d => d.TestItemId);
        }
    }
}
