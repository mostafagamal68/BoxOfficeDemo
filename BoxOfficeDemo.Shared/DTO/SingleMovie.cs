using BoxOfficeDemo.Shared.Extensions;
using System.ComponentModel.DataAnnotations;

namespace BoxOfficeDemo.Shared.Models
{
    public class SingleMovie
    {
        public SingleMovie()
        {
            MovieID = new GenerateNewID().GetNewID;
        }
        public decimal? MovieID { get; set; }

        [Required]
        public string? MovieName { get; set; }

        [Required]
        public string? Image { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public DateTime? ReleasedDate { get; set; }

        [Required]
        public int? ParentalGuide { get; set; }

        [Required]
        public TimeSpan? Length { get; set; }
        public string? Genere { get; set; }
        public decimal? Rate { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public string? Stars { get; set; }
        public bool? IsNew { get; set; }
        //public List<ReviewsList> Reviews { get; set; } = new();
    }
}
