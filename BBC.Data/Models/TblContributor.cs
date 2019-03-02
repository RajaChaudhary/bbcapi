using System;
using System.Collections.Generic;

namespace BBC.Data.Models
{
    public partial class TblContributor
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
