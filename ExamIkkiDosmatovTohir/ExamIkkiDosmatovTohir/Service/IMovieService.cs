using ExamIkkiDosmatovTohir.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace ExamIkkiDosmatovTohir.Service
{
    public interface IMovieService
    {
        public List<MovieExtensions> GetAllMoviesByDirector(string director);
        public  MovieExtensions  GetTopRatedMovie();
        public List<MovieExtensions> GetMovieReleasedAfterYear(int yeer);
        public MovieExtensions GetHighestGrossingMovie();
        public List<MovieExtensions> SearchMoviesByTitle(string keyword);
        public List<MovieExtensions> GetMoviesWithunDurationRange(int minMinutes, int maxMinutes);
        public long  GetTotalBoxOfficeEarningsByDirector(string director);
        public List<MovieExtensions> GetMoviesSortedByRating();
        public List<MovieExtensions> GetRecentMovies(int years);






    }
}