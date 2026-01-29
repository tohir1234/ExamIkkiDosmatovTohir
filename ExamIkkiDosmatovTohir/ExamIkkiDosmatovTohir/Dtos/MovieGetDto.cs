using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamIkkiDosmatovTohir.Dtos
{
    public  class MovieGetDto
    {
       
        public string Title { get; set; }
        public string Director { get; set; }
        public int DurationMinutes { get; set; }
        public double Rating { get; set; }
        public long BoxOfficeEarnings { get; set; }
        public DateTime ReleaseDte { get; set; }
    }
}
