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
        public TestType TestType {get;set;}
        public string TestItem { get; set; }
        public TestResult Result {get;set;}
        public string Detail { get; set; }
        public string TestOutline { get; set; }
        public string TargetDevice { get; set; }
        public string TargetVersion { get; set; }
        public BugCategory BugCategory { get; set; }
        public BugSubCategory BugSubCategory { get; set; }
        public string AnalysisDetail { get; set; }
        public string AnalysisPIC { get; set; }
        public string AnalysisRemark { get; set; }
        public AnalysisStatus AnalysisStatus { get; set; }
        public string AnaylysisNote { get; set; }    
        
    }
}
