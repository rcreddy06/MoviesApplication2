using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesApplication
{
    public partial class GenreInfo : Form
    {
        Form1 mainForm;
        public GenreInfo(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            genreBindingSource.DataSource = mainForm.database.Genres;
            movieGenreBindingSource.DataSource = mainForm.database.MovieGenres;



        }

        private void GenreInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.MovieGenre' table. You can move, or remove it, as needed.
            this.movieGenreTableAdapter.Fill(this.movieDatabaseDataSet.MovieGenre);
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.movieDatabaseDataSet.Genre);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.movieGenreBindingSource.EndEdit();
                mainForm.database.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill All values");
                Console.WriteLine(ex);
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
