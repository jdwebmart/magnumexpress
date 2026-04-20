using System.ComponentModel.DataAnnotations;

namespace TrackingWebAPI.Models
{
    public class AirlineMaster
    {
        [Key]
        public int AIRID { get; set; }

        public string? AirlineCode { get; set; }
        public string? AirlineName { get; set; }
        public double?  Slab1 { get; set; }
        public double?  Slab2 { get; set; }
        public double?  Slab3 { get; set; }
        public double?  Slab4 { get; set; }
        public double? Slab5 { get; set; }
        public string? createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public string? IsActive { get; set; }
        public DateTime? end_dt { get; set; }
    }
}
