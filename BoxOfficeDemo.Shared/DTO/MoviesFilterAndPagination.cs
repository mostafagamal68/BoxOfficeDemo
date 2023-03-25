using BoxOfficeDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfficeDemo.Shared.DTO
{
    public class MoviesFilterAndPagination
    {
        public int PageIndex { get; set; }
        public int Count { get; set; }

        public List<MoviesList> Items { get; set; } = new();
    }
}
