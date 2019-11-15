using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenMovieDatabase.Client;

namespace MovieDataAccessLayer
{
    public class MovieDataAccessor
    {

        public static List<Movie> RetrieveMovieList()
        {
            List<Movie> movieList = new List<Movie>();
            string dataPath = DataSource.GetfilePath();
            FileStream movielist = null;
            StreamReader reader = null;
            char[] seperator = { ',' };
            try
            {
                // AppData.DataPath is returning null value. 
                movielist = new FileStream(dataPath + @"\movielist.csv", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(movielist);
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts;
                    if (line.Length > 16)
                    {
                        parts = line.Split(seperator);
                        if (parts.Count() == 2)
                        {
                            Movie newMovie = new Movie();

                            newMovie.ImdbID = parts[0];
                            newMovie.Title = parts[1];


                            movieList.Add(newMovie);

                        }
                    }
                }
                reader.Close();
                
            }

            catch (Exception)
            {
                throw;
            }
            return movieList;
        }


        public static async Task<List<Movie>> RetrieveMovieListAsync()
        {
            List<Movie> movieList = new List<Movie>();
            var omdb = new OpenMovieDatabaseClient("333725e1", Apihelper.ApiClient);
            string dataPath = DataSource.GetfilePath();
            FileStream movielist = null;
            StreamReader reader = null;
            char[] seperator = { ',' };
            try
            {
                // AppData.DataPath is returning null value. 
                movielist = new FileStream(dataPath + @"\movielist.csv", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(movielist);
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts;
                    if (line.Length > 16)
                    {
                        parts = line.Split(seperator);
                        if (parts.Count() == 2)
                        {
                            Movie newMovie = new Movie();

                            GetByIdOrTitleRequest movie = new GetByIdOrTitleRequest();
                            movie.ImdbId = parts[0];
                            movie.Plot = PlotType.Full;
                            GetByIdOrTitleResponse response = await omdb.GetByIdOrTitleAsync(movie);

                            newMovie.ImdbID = response.ImdbID;
                            newMovie.Title = response.Title;
                            newMovie.Released = (DateTime)response.Released;
                            newMovie.Genre = response.Genre[0];
                            newMovie.PlotFileName = response.Plot;
                            newMovie.PosterFileName = response.Poster;

                            movieList.Add(newMovie);

                        }
                    }
                }
                reader.Close();
            }

            catch (Exception)
            {
                throw;
            }
            return movieList;
        }


        //public static Summary RetrievePlot(Movie movie)
        //{
        //    Summary newPlot = new Summary();
        //    string dataPath = DataSource.GetfilePath() + @"\" + movie.PlotFileName;
        //    try
        //    {
        //        FileStream moviePlot = new FileStream(dataPath, FileMode.Open, FileAccess.Read);
        //        StreamReader reader = new StreamReader(moviePlot);
        //        newPlot.Plot = reader.ReadToEnd();
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return newPlot;
        //}

        public static bool AddMovie(Movie movie)
        {
            try
            {
                StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + AppData.MovieListFileName, true);
                fileWriter.WriteLine(movie.ImdbID + ", " +
                            movie.Title);

                fileWriter.Close();

                try
                {
                    RetrieveMovieList();
                }
                catch
                {
                    throw;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static async Task<Movie> RetrieveMovieAsync(string title)
        {
            try
            {
                Movie movie = new Movie();
                var omdb = new OpenMovieDatabaseClient("333725e1", Apihelper.ApiClient);

                GetByIdOrTitleRequest movieTitle = new GetByIdOrTitleRequest();
                movieTitle.Title = title;
                movieTitle.Plot = PlotType.Full;
                GetByIdOrTitleResponse movieResponse = await omdb.GetByIdOrTitleAsync(movieTitle);

                movie.PlotFileName = movieResponse.Plot;
                movie.ImdbID = movieResponse.ImdbID;
                movie.PosterFileName = movieResponse.Poster;
                movie.Title = movieResponse.Title;
                movie.Released = (DateTime)movieResponse.Released;
                movie.Genre = movieResponse.Genre[0];

                return movie;
            }
            catch
            {
                throw;
            }
        }
    }
}
