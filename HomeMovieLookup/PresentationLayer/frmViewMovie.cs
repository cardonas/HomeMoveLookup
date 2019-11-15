using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieControlLayer;
using MovieDataAccessLayer;

namespace PresentationLayer
{
    public partial class frmViewMovie : Form
    {
        private MovieManager _movieManager;
        int _movieIndex;
       // Summary _plot;

        public frmViewMovie(MovieManager movieManager, int movieIndex)
        {
            InitializeComponent();
            _movieManager = movieManager;
            _movieIndex = movieIndex;
        }

        private void FrmViewMovie_Load(object sender, EventArgs e)
        {
            DisplayMovie();
        }

        // Displays all movies Data for each movie
        private void DisplayMovie()
        {
            try
            {
                //_plot = _movieManager.FetchMoviePlot(_movieIndex);
                this.txtSummary.Text = _movieManager.MovieLIst[_movieIndex].PlotFileName;
                this.txtMovieName.Text = _movieManager.MovieLIst[_movieIndex].Title;
                this.txtImdbID.Text = _movieManager.MovieLIst[_movieIndex].ImdbID;
                this.txtGenre.Text = _movieManager.MovieLIst[_movieIndex].Genre;
                this.txtReleaseDate.Text = _movieManager.MovieLIst[_movieIndex].Released.ToShortDateString();
                this.picMovieImage.ImageLocation = _movieManager.MovieLIst[_movieIndex].PosterFileName.ToString();
                this.btnNext.Select();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Will move to the next movie in the list and return to the first move after last movie is reached
        private void BtnNext_Click(object sender, EventArgs e)
        {
            _movieIndex++;
            if(_movieIndex > _movieManager.MovieLIst.Count - 1)
            {
                _movieIndex = 0;
            }
            DisplayMovie();
        }

        // Allows user to close the window and return to main.
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
