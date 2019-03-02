using System;
using System.Collections.Generic;

namespace BBC.Data.Models
{
    public partial class TblLog
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public bool TopicId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
