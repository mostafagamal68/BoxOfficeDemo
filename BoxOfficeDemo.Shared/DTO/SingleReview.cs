using BoxOfficeDemo.Shared.Extensions;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace BoxOfficeDemo.Shared.Models
{
    public class SingleReview
    {
        public decimal? ReviewID { get; set; }
        public decimal? MovieID { get; set; }
        public string? UserID { get; set; }

        [Required]
        public int? Rate { get; set; }

        [Required]
        public string? Feedback { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
