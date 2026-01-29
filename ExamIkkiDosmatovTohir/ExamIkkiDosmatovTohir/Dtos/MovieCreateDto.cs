using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamIkkiDosmatovTohir.Dtos
{
    public  class MovieCreateDto
    {

        public class MovieCreateDto
        {
            public string Title { get; set; }
            public string Director { get; set; }
            public int DurationMinutes { get; set; }
            public double Rating { get; set; }
            public long BoxOfficeEarnings { get; set; }
            public DateTime ReleaseDate { get; set; }
        }


    }
}
