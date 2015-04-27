using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain.Mapping
{
    public class TestItemMap : EntityTypeConfiguration<TestItem>
    {
        public TestItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TestType)
                .IsRequired();
                

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .IsRequired();
                

            this.Property(t => t.Detail)
                .IsRequired()
                .HasMaxLength(3000);

            this.Property(t => t.TestOutline)
                .HasMaxLength(3000);

            this.Property(t => t.TargetDevice)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TargetVersion)                
                .HasMaxLength(1000);

            this.Property(t => t.BugCategoryId).IsRequired();


            this.Property(t => t.BugSubCategoryId).IsRequired();
                
                

            this.Property(t => t.AnalysisDetail)
                .HasMaxLength(3000);

            this.Property(t => t.AnalysisPIC)
                .HasMaxLength(20);

            this.Property(t => t.AnalysisRemark)
                .HasMaxLength(3000);

            this.Property(t => t.AnalysisStatusId);

            this.Property(t => t.AnaylysisNote).HasMaxLength(3000);

            // Table & Column Mappings

            //Relations 

            
            this.HasOptional(t => t.AnalysisStatus)
               .WithMany(t => t.TestItems)
               .HasForeignKey(d => d.AnalysisStatusId);

            this.HasRequired(t => t.BugCategory)
               .WithMany(t => t.TestItems)
               .HasForeignKey(d => d.BugCategoryId);

            this.HasRequired(t => t.BugSubCategory)
               .WithMany(t => t.TestItems)
               .HasForeignKey(d => d.BugSubCategoryId);


        }
    }
}
