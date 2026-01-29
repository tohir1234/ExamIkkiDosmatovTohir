using ExamIkkiDosmatovTohir.Enteties;
using ExamIkkiDosmatovTohir.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamIkkiDosmatovTohir.Service;

public class MovieService : IMovieService
{
    private List<MovieExtensions> movies = new();

    public List<MovieExtensions> GetAllMoviesByDirector(string director)
    {
        List<MovieExtensions> result = new();
        foreach (var movie in movies)
        {
            if (movie.Director == director)
                result.Add(movie);
        }
        return result;
    }

    public MovieExtensions GetTopRatedMovie()
    {
      
    }

    public List<MovieExtensions> GetMovieReleasedAfterYear(int year)
    {
        List<MovieExtensions> result = new();
        foreach (var movie in movies)
        {
            if (movie.ReleaseDate.Year > year)
                result.Add(movie);
        }
        return result;
    }

    public MovieExtensions GetHighestGrossingMovie()
    {
      
    }

    public List<MovieExtensions> SearchMoviesByTitle(string keyword)
    {
        List<MovieExtensions> result = new();
        foreach (var movie in movies)
        {
            if (movie.Title.Contains(keyword))
                result.Add(movie);
        }
        return result;
    }

    public List<MovieExtensions> GetMoviesWithunDurationRange(int min, int max)
    {
        List<MovieExtensions> result = new();
        foreach (var movie in movies)
        {
            if (movie.DurationMinutes >= min && movie.DurationMinutes <= max)
                result.Add(movie);
        }
        return result;
    }

    public long GetTotalBoxOfficeEarningsByDirector(string director)
    {
        long sum = 0;
        foreach (var movie in movies)
        {
            if (movie.Director == director)
                sum += movie.BoxOfficeEarnings;
        }
        return sum;
    }

    public List<MovieExtensions> GetMoviesSortedByRating()
    {
        
    }

    public List<MovieExtensions> GetRecentMovies(int years)
    {
        List<MovieExtensions> result = new();
        DateTime limit = DateTime.Now.AddYears(-years);

        foreach (var movie in movies)
        {
            if (movie.ReleaseDate >= limit)
                result.Add(movie);
        }
        return result;
    }
}
