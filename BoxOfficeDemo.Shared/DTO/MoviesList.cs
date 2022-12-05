namespace BoxOfficeDemo.Shared.Models
{
    public class MoviesList
    {
        public decimal? MovieID { get; set; }
        public string? MovieName { get; set; }
        public string? Image { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public int? ParentalGuide { get; set; }
        public TimeSpan? Length { get; set; }
        public string? Genere { get; set; }
        public decimal? Rate { get; set; }
    }
}
