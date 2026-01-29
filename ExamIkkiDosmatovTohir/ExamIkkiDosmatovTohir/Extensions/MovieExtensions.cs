using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamIkkiDosmatovTohir.Extensions;


public static  class MovieExtensions
{
    public DateTime ReleaseDate { get; internal set; }

    public static class MovieExtensions
    {
        // minut → soat
        public static double ToHours(this MovieDto movie)
        {
            return movie.DurationMinutes / 60.0;
        }

        // listdagi barcha daromad yig‘indisi
        public static long TotalBoxOffice(this List<MovieDto> movies)
        {
            long sum = 0;
            foreach (var movie in movies)
            {
                sum += movie.BoxOfficeEarnings;
            }
            return sum;
        }
    }



}
