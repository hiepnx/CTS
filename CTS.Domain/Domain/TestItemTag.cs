using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Domain.Domain.Base;

namespace CTS.Domain.Domain
{
    public class TestItemTag:BaseEntity
    {
        public string TagName { get; set; }
        public int TestItemId { get; set; }
        public TestItem TestItem { get; set; }
    }
}
