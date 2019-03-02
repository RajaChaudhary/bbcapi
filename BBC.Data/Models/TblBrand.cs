using System;
using System.Collections.Generic;

namespace BBC.Data.Models
{
    public partial class TblBrand
    {
        public int Id { get; set; }
        public string BName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
