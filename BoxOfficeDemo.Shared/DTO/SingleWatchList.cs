using BoxOfficeDemo.Shared.Configurations;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace BoxOfficeDemo.Shared.Models
{
    public class SingleWatchList
    {
        public decimal Id { get; set; }
        public decimal MovieID { get; set; }
        public string? MovieName { get; set; }
        public string? UserID { get; set; }
    }
}
