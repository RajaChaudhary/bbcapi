using System;
using System.Collections.Generic;

namespace BBC.Data.Models
{
    public partial class TblRole
    {
        public long Id { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CreatedBy { get; set; }
    }
}
