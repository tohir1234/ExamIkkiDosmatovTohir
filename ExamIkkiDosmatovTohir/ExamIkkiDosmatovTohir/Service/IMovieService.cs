using ExamIkkiDosmatovTohir.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace ExamIkkiDosmatovTohir.Service
{
    public interface IMovieService
    {
        public List<MovieDto> GetAllMoviesByDirector(string director);
        public  MovieDto  GetTopRatedMovie();
        public List<MovieDto> GetMovieReleasedAfterYear(int yeer);
        public MovieDto GetHighestGrossingMovie();
        public List<MovieDto> SearchMoviesByTitle(string keyword);
        public List<MovieDto> GetMoviesWithunDurationRange(int minMinutes, int maxMinutes);
        public long  GetTotalBoxOfficeEarningsByDirector(string director);
        public List<MovieDto> GetMoviesSortedByRating();
        public List<MovieDto> GetRecentMovies(int years);






    }
}