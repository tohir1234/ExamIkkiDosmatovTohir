using ExamIkkiDosmatovTohir.Dtos;
using ExamIkkiDosmatovTohir.Enteties;

namespace ExamIkkiDosmatovTohir;

internal class Program
{
    static void Main(string[] args)
    {
        MovieDto dto = new MovieDto
        {
            MovieId = movie.MovieId,
            Title = movie.Title,
            Director = movie.Director,
            DurationMinutes = movie.DurationMinutes,
            Rating = movie.Rating,
            BoxOfficeEarnings = movie.BoxOfficeEarnings,
            ReleaseDate = movie.ReleaseDate
        };

    }                       
}