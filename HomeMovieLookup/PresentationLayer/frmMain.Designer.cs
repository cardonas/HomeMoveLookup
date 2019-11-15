namespace PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMovie = new System.Windows.Forms.ListView();
            this.colMovieTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMovie
            // 
            this.lstMovie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMovieTitle,
            this.colReleaseDate,
            this.colGenre});
            this.lstMovie.FullRowSelect = true;
            this.lstMovie.GridLines = true;
            this.lstMovie.Location = new System.Drawing.Point(15, 8);
            this.lstMovie.Margin = new System.Windows.Forms.Padding(2);
            this.lstMovie.Name = "lstMovie";
            this.lstMovie.Size = new System.Drawing.Size(519, 247);
            this.lstMovie.TabIndex = 1;
            this.lstMovie.UseCompatibleStateImageBehavior = false;
            this.lstMovie.View = System.Windows.Forms.View.Details;
            // 
            // colMovieTitle
            // 
            this.colMovieTitle.Text = "Movie Title";
            this.colMovieTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMovieTitle.Width = 305;
            // 
            // colReleaseDate
            // 
            this.colReleaseDate.Text = "Release Date";
            this.colReleaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colReleaseDate.Width = 90;
            // 
            // colGenre
            // 
            this.colGenre.Text = "Genre";
            this.colGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGenre.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnViewMovie
            // 
            this.btnViewMovie.Location = new System.Drawing.Point(15, 273);
            this.btnViewMovie.Name = "btnViewMovie";
            this.btnViewMovie.Size = new System.Drawing.Size(112, 49);
            this.btnViewMovie.TabIndex = 5;
            this.btnViewMovie.Text = "View";
            this.btnViewMovie.UseVisualStyleBackColor = true;
            this.btnViewMovie.Click += new System.EventHandler(this.BtnViewMovie_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.btnViewMovie);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMovie);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Lookup ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMovie;
        private System.Windows.Forms.ColumnHeader colReleaseDate;
        private System.Windows.Forms.ColumnHeader colGenre;
        private System.Windows.Forms.ColumnHeader colMovieTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewMovie;
    }
}

