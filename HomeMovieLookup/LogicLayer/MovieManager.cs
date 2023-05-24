using MovieDataAccessLayer;
using MovieObjectLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MovieControlLayer
{
    public class MovieManager
    {
        List<Movie> _movieList;
        public MovieManager()
        {
            try
            {
                 _movieList = MovieDataAccessor.RetrieveMovieListAsync().Result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Movie> MovieLIst
        {
            get { return _movieList;}
        }

        public async Task<List<Movie>> AddMovieAsync(Movie movie)
        {
            try
            {
                if (MovieDataAccessor.AddMovie(movie))
                {
                    _movieList = await MovieDataAccessor.RetrieveMovieListAsync();
                }
                return _movieList;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
