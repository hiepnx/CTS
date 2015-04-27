using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Domain.Domain.Initializer;
using CTS.Domain.Domain.Mapping;

namespace CTS.Domain.Domain
{
    public class CTSDbContext: DbContext
    {
        static CTSDbContext()
        {
            Database.SetInitializer<CTSDbContext>(new CTSInitializer());
        }

        public CTSDbContext()
            : base("Name=CTSDbContext")
        {
        }
        public ObjectContext ObjectContext
        {
            get
            {
                return (this as IObjectContextAdapter).ObjectContext; 
            }
        }

        public DbSet<AnalysisStatus> AnalysisStatuses { get; set; }
        public DbSet<BugCategory> BugCategories { get; set; }
        public DbSet<BugSubCategory> BugSubCategories { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<TestAttachment> TestAttachments { get; set; }
        public DbSet<TestComment> TestComments { get; set; }
        public DbSet<TestItem> TestItems { get; set; }
        public DbSet<TestItemTag> TestItemTags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnalysisStatusMap());
            modelBuilder.Configurations.Add(new BugCategoryMap());
            modelBuilder.Configurations.Add(new BugSubCategoryMap());
            modelBuilder.Configurations.Add(new SettingMap());
            modelBuilder.Configurations.Add(new TestAttachmentMap());
            modelBuilder.Configurations.Add(new TestCommentMap());
            modelBuilder.Configurations.Add(new TestItemMap());
            modelBuilder.Configurations.Add(new TestItemTagMap());
        }
    }
}
