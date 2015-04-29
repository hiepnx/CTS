using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Domain.Data;
using CTS.Domain.Domain;

namespace CTS.Services.TestItemServices
{
    class TestItemService : ITestItemService
    {
        public TestItemService()
        {
            if (Repository == null) Repository = new EfRepository<TestItem>(new CTSDbContext());

        }
        public IRepository<TestItem> Repository
        {
            get;
            set;
        }

        public TestItem GetTicket(int Id)
        {
            return Repository.GetById(Id);
        }

        public IEnumerable<TestItem> ListTestItems(bool includeComments)
        {
            return Repository.Table;
        }

        public int? DeleteTestItem(int Id)
        {
            Repository.Delete(Repository.Table.Where(i=>i.Id == Id).FirstOrDefault());
            return 1;
        }

        public int? CreateNewTestItem(TestItem testItem)
        {
            throw new NotImplementedException();
        }

        public bool EditTestItemDetails(TestItem testItem, string comment)
        {
            throw new NotImplementedException();
        }

        public bool AddCommentToTestItem(TestItem testItem, string comment)
        {
            throw new NotImplementedException();
        }

        public bool ModifyAttachmentsForTestItem(TestItem testItem, string comment, List<TestAttachment> attachments)
        {
            throw new NotImplementedException();
        }

        public TestAttachment GetAttachment(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}
