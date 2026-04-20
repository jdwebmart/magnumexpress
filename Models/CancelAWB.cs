using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackingWebAPI.Models
{
    public class CancelAWB
    {
        [Key]
        public int caid { get; set; }
        public string? AWBNumber { get; set; }
        public string? Reason { get; set; }
        public string? createdby { get; set; }
        public DateTime? createdon { get; set; }
        public string? mdfby { get; set; }
        public DateTime? mdfon { get; set; }
        public string? IsActive { get; set; }
        [Column("end_dt")]
        public string? EndDate { get; set; }
    }
}
