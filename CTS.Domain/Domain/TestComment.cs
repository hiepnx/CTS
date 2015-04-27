using CTS.Domain.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain
{
    public class TestComment : BaseEntity
    {
        public int TestItemId { get; set; }
        public TestItem TestItem { get; set; }
        public string Comment { get; set; }
        public bool IsHtml { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CommentedDate { get; set; }

    }
}
