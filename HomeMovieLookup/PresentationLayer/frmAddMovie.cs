using MovieControlLayer;
using MovieDataAccessLayer;
using OpenMovieDatabase.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAddMovie : Form
    {
        string dataPath = Application.StartupPath + @"\moviedata";

        MovieManager _movieManager;

        public frmAddMovie(MovieManager movieManager)
        {
            _movieManager = movieManager;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSearch_ClickAsync(object sender, EventArgs e)
        {
            await searchMovie(txtMovieName.Text);
        }

        private async Task searchMovie(string movieTitle)
        {
            try
            {
                Movie movie = await MovieDataAccessor.RetrieveMovieAsync(movieTitle);

                txtGenre.Text = movie.Genre;
                txtSummary.Text = movie.PlotFileName;
                txtReleaseDate.Text = movie.Released.ToShortDateString();
                txtImdbID.Text = movie.ImdbID;
                picMovieImage.ImageLocation = movie.PosterFileName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error, \nPlease check your entry.");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            Movie movie = new Movie();
            movie.Title = txtMovieName.Text;
            movie.ImdbID = txtImdbID.Text;
            
            // Checks if movie is already in list and exits event if movie is alreay in list
            foreach (Movie movieCheck in _movieManager.MovieLIst)
            {
                if (txtMovieName.Text.ToLower() == movieCheck.Title.ToLower())
                {
                    MessageBox.Show("Movie is Already in list");
                    return;
                }
            }

            // if move isn't in list this will save it to list and to csv file
            try
            {
                MovieDataAccessor.AddMovie(movie);
                MessageBox.Show("Movie Added To List!");
                try
                {
                    movie.Released = DateTime.Parse(txtReleaseDate.Text);
                }
                catch
                {
                    MessageBox.Show("There was an issue with fetching the date.");
                }
                
                movie.Genre = txtGenre.Text;
                movie.PosterFileName = new Uri(picMovieImage.ImageLocation);
                movie.PlotFileName = txtSummary.Text;
                _movieManager.MovieLIst.Add(movie);
            }
            catch
            {
                MessageBox.Show("Failed to add Movie!");
            }
        }
    }
}
