namespace PresentationLayer
{
    partial class frmViewMovie
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.picMovieImage = new System.Windows.Forms.PictureBox();
            this.txtImdbID = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "IMDB ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Movie Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 384);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(69, 384);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 37);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(187, 131);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(236, 235);
            this.txtSummary.TabIndex = 23;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(170, 74);
            this.txtReleaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.ReadOnly = true;
            this.txtReleaseDate.Size = new System.Drawing.Size(105, 20);
            this.txtReleaseDate.TabIndex = 22;
            // 
            // picMovieImage
            // 
            this.picMovieImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picMovieImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMovieImage.Location = new System.Drawing.Point(17, 131);
            this.picMovieImage.Margin = new System.Windows.Forms.Padding(2);
            this.picMovieImage.Name = "picMovieImage";
            this.picMovieImage.Size = new System.Drawing.Size(145, 234);
            this.picMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovieImage.TabIndex = 21;
            this.picMovieImage.TabStop = false;
            // 
            // txtImdbID
            // 
            this.txtImdbID.Location = new System.Drawing.Point(319, 74);
            this.txtImdbID.Margin = new System.Windows.Forms.Padding(2);
            this.txtImdbID.Name = "txtImdbID";
            this.txtImdbID.ReadOnly = true;
            this.txtImdbID.Size = new System.Drawing.Size(105, 20);
            this.txtImdbID.TabIndex = 19;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(16, 75);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(105, 20);
            this.txtGenre.TabIndex = 18;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(16, 31);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.ReadOnly = true;
            this.txtMovieName.Size = new System.Drawing.Size(407, 20);
            this.txtMovieName.TabIndex = 17;
            // 
            // frmViewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.picMovieImage);
            this.Controls.Add(this.txtImdbID);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtMovieName);
            this.Name = "frmViewMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewMovie";
            this.Load += new System.EventHandler(this.FrmViewMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMovieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.PictureBox picMovieImage;
        private System.Windows.Forms.TextBox txtImdbID;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtMovieName;
    }
}