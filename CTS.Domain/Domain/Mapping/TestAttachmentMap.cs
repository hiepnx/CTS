using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain.Mapping
{
    class TestAttachmentMap: EntityTypeConfiguration<TestAttachment>
    {
        public TestAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TestItemId)
                .IsRequired();
            
            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FileSize)
                .IsRequired();
                
            this.Property(t => t.FileType)
                .IsRequired().HasMaxLength(10);
            

            this.Property(t=>t.UploadedBy).HasMaxLength(100);
            this.Property(t=>t.UploadedDate).IsRequired();
            this.Property(t => t.FileContents).IsRequired();
            this.Property(t => t.FileDescription).HasMaxLength(2000);
            this.Property(t => t.IsPending);


            //Table & Column Mapping
            this.ToTable("TestAttachment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TestItemId).HasColumnName("TestItemId");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.UploadedBy).HasColumnName("UploadedBy");
            this.Property(t => t.UploadedDate).HasColumnName("UploadedDate");
            this.Property(t => t.FileContents).HasColumnName("FileContents");
            this.Property(t => t.FileDescription).HasColumnName("FileDescription");
            this.Property(t => t.IsPending).HasColumnName("IsPending");

            //Relationships
            this.HasRequired(t=>t.TestItem).WithMany(t=> t.TestAttachments).HasForeignKey(t=>t.TestItemId);
        }
    }
    
}
