using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain.Initializer
{
    public class CTSInitializer : DropCreateDatabaseIfModelChanges<CTSDbContext>
    {
        protected override void Seed(CTSDbContext context)
        {
            context.AnalysisStatuses.AddRange(GetAnalysisStatuses());
            context.BugCategories.AddRange(GetBugCategories());
            context.BugSubCategories.AddRange(GetSubBugCategories());
        }

        private IEnumerable<BugSubCategory> GetSubBugCategories()
        {
            List<BugSubCategory> ret = new List<BugSubCategory>();
            ret.Add(new BugSubCategory { Name = "Hardware unsupported", Description = "Board does not contain this device" });
            ret.Add(new BugSubCategory { Name = "ROM Unsupported", Description = "Current ROM files does not support features (this can be found in release note)" });
            ret.Add(new BugSubCategory { Name = "Android Porting Miss", Description = "This bug is caused by lack of configure file or bugs in external library" });
            ret.Add(new BugSubCategory { Name = "Linux kernel", Description = "This bugs is caused by linux kernel" });
            ret.Add(new BugSubCategory { Name = "Device driver", Description = "This bugs is caused by device driver" });
            ret.Add(new BugSubCategory { Name = "PF Application", Description = "This bugs belongs to PF applications" });
            ret.Add(new BugSubCategory { Name = "CTS", Description = "Bugs caused by CTS wrong implementation" });
            ret.Add(new BugSubCategory { Name = "CTSVerifier", Description = "Bugs caused by CTSVerifier wrong implementation" });
            ret.Add(new BugSubCategory { Name = "CDD", Description = "Bugs caused by CDD wrong implementation" });
            ret.Add(new BugSubCategory { Name = "GTS", Description = "Bugs caused by GTS wrong implementation" });
            ret.Add(new BugSubCategory { Name = "CTS Unstable", Description = "Bugs caused by CTS Unstable i.e. test case run independent with other test cases --> it can pass" });
            ret.Add(new BugSubCategory { Name = "Need Special Settings", Description = "Bugs caused by needing some specials settings before running" });
            return ret;
        }

        private IEnumerable<BugCategory> GetBugCategories()
        {
            List<BugCategory> ret = new List<BugCategory>();
            ret.Add(new BugCategory { Name = "Environment Bug", Description = "Bugs are caused by CTS/Need Special Setting/CTS Unstable" });
            ret.Add(new BugCategory { Name = "Target Bug", Description = "Bugs are caused by Target Broad/ROM File. For the sub-category of this bug, checking the below table to forward to correct developer" });
            return ret;
        }

        private List<AnalysisStatus> GetAnalysisStatuses()
        {
            List<AnalysisStatus> ret = new List<AnalysisStatus>();
            ret.Add(new AnalysisStatus {Name= "Wait for analyzing",Description = "PHNL hasn't start analyzing NG cases" });
            ret.Add(new AnalysisStatus {Name = "Analyzing",Description = "PHNL is analyzing NG cases" });
            ret.Add(new AnalysisStatus {Name = "Analyzed",Description = "PHNL finished analysis NG  cases" });
            ret.Add(new AnalysisStatus { Name = "Closed", Description = "The test cases are already fixed by developer --> because OK cases" });
            return ret;
        }
    }
}
