namespace BoxOfficeDemo.Shared.Models
{
    public class ReviewsList
    {
        public decimal? ReviewID { get; set; }
        public decimal? MovieID { get; set; }
        public string? UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Rate { get; set; }
        public string? Feedback { get; set; }
        public DateTime? ReviewDate { get; set; }

    }
}
