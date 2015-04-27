using CTS.Domain.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain
{
    public class TestAttachment:BaseEntity
    {
        public int TestItemId { get; set; }
        public TestItem TestItem { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string FileType { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadedDate { get; set; }
        public byte[] FileContents { get; set; }
        public string FileDescription { get; set; }
        public bool IsPending { get; set; }
    }
}
