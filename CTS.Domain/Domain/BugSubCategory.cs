﻿using CTS.Domain.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Domain.Domain
{
    public class BugSubCategory:BaseEntity
    {
        public BugSubCategory()
        {
            this.TestItems = new List<TestItem>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<TestItem> TestItems { get; set; }
    }
}
