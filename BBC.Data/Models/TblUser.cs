using System;
using System.Collections.Generic;

namespace BBC.Data.Models
{
    public partial class TblUser
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
