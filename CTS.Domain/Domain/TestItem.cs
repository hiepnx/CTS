using CTS.Domain.Domain.Base;
using CTS.Domain.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain
{
    public class TestItem:BaseEntity
    {
        public TestItem()
        {
            this.TestItemTags = new List<TestItemTag>();
            this.TestAttachments = new List<TestAttachment>();
            this.TestComments = new List<TestComment>();
        }
        public TestType TestType {get;set;}

        public string Name { get; set; }

        public TestResult Result {get;set;}

        public string Detail { get; set; }

        public string TestOutline { get; set; }

        public string TargetDevice { get; set; }

        public string TargetVersion { get; set; }

        public Nullable<int> BugCategoryId { get; set; }
        public virtual BugCategory BugCategory { get; set; }

        public Nullable<int> BugSubCategoryId { get; set; }
        public BugSubCategory BugSubCategory { get; set; }

        public string AnalysisDetail { get; set; }

        public string AnalysisPIC { get; set; }

        public string AnalysisRemark { get; set; }

        public Nullable<int> AnalysisStatusId { get; set; }
        public AnalysisStatus AnalysisStatus { get; set; }

        public string AnaylysisNote { get; set; }

        public virtual ICollection<TestItemTag> TestItemTags { get; set; }
        public virtual ICollection<TestAttachment> TestAttachments { get; set; }
        public virtual ICollection<TestComment> TestComments { get; set; }


    }
}
