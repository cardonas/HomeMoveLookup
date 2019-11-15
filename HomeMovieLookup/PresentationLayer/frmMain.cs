using MovieControlLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        private MovieManager _movieManager = new MovieManager();

        public frmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            populateList();
        }

        // Populates list box with data from the CSV File.
        private void populateList()
        {
            lstMovie.Items.Clear();
            for (int i = 0; i < _movieManager.MovieLIst.Count; i++)
            {
                this.lstMovie.Items.Add(_movieManager.MovieLIst[i].Title);
                this.lstMovie.Items[this.lstMovie.Items.Count - 1].SubItems.Add(_movieManager.MovieLIst[i].Released.ToShortDateString());
                this.lstMovie.Items[this.lstMovie.Items.Count - 1].SubItems.Add(_movieManager.MovieLIst[i].Genre);
            }
        }

        // Allow user to see current list of all movied that have been added
        private void BtnViewMovie_Click(object sender, EventArgs e)
        {
            if (this.lstMovie.SelectedIndices.Count > 0)
            {
                this.Hide();
                var articleForm = new frmViewMovie(_movieManager, lstMovie.SelectedIndices[0]);
                articleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nothing selected!");
            }
            this.Show();
        }

        // Allow user to exit application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Allow a user to add a movie
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            frmAddMovie addMovie = new frmAddMovie(_movieManager);
            this.Hide();
            addMovie.ShowDialog();
            /*
             The line below makes the program freeze. Without this
             line the movie list doesn't refresh currectly with the newly added movie
             */
            this.Show();
            //_movieManager = new MovieManager();
            for (int i = 0; i < _movieManager.MovieLIst.Count; i++)
            {
                Console.WriteLine(_movieManager.MovieLIst[i].ToString());
            }
            
            populateList();

        }
    }
}
