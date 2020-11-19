using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpDatedBy { get; set; }
    }
}
