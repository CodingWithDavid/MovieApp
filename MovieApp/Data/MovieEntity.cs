
using System.Collections.Generic;

namespace MovieApp.Data
{
    public class MovieEntity
    {
        public int Page { get; set; }
        public List<MovieDetail> Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
