namespace XML_Movie_Reader
{
    partial class Form1
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
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(505, 212);
            this.deleteMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(70, 37);
            this.deleteMovieButton.TabIndex = 11;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(505, 150);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(70, 37);
            this.addMovieButton.TabIndex = 10;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.Location = new System.Drawing.Point(14, 140);
            this.genreListBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(205, 69);
            this.genreListBox.TabIndex = 9;
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(247, 44);
            this.movieListBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(240, 290);
            this.movieListBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Movies:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 355);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.movieListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

