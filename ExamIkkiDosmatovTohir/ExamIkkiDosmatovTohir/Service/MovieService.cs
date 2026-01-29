using ExamIkkiDosmatovTohir.Enteties;
using ExamIkkiDosmatovTohir.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamIkkiDosmatovTohir.Service
{
    public class MovieService : IMovieService
    {
        public List<Movie> Moives;
        public MovieService()
        {
            Moives = new List<Movie>();
        }
        public List<MovieDto> GetAllMoviesByDirector(string director)
        {
            foreach (var movie in Moives)
            {
                if (movie.Director == director)
                    return movie.

            }
          
        }

        public MovieDto GetHighestGrossingMovie()
        {
            throw new NotImplementedException();
        }

        public List<MovieDto> GetMovieReleasedAfterYear(int yeer)
        {
            throw new NotImplementedException();
        }

        public List<MovieDto> GetMoviesSortedByRating()
        {
            throw new NotImplementedException();
        }

        public List<MovieDto> GetMoviesWithunDurationRange(int minMinutes, int maxMinutes)
        {
            throw new NotImplementedException();
        }

        public List<MovieDto> GetRecentMovies(int years)
        {
            throw new NotImplementedException();
        }

        public MovieDto GetTopRatedMovie()
        {

            foreach(var movie in Moives)
            {
                if ( )
            }
        }  


        public long GetTotalBoxOfficeEarningsByDirector(string director)
        {
            throw new NotImplementedException();
        }

        public List<MovieDto> SearchMoviesByTitle(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
