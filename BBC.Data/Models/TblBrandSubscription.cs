using System;
using System.Collections.Generic;

namespace BBC.Data.Models
{
    public partial class TblBrandSubscription
    {
        public long Id { get; set; }
        public int BrandId { get; set; }
        public bool Series { get; set; }
        public DateTime? NumberOfEpisod { get; set; }
        public string EpisodeNameFormate { get; set; }
        public int? ContributorId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool IaActive { get; set; }
    }
}
