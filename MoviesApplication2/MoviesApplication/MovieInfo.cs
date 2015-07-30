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
    public partial class MovieInfo : Form
    {
        Form1 mainForm;

        public MovieInfo(Form1 mainForm)
        {
            
            InitializeComponent();
            this.mainForm = mainForm;
            moviesBindingSource.DataSource = mainForm.database.Movies;

        }


        private void MovieInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.movieDatabaseDataSet.Movies);
            // TODO: This line of code loads data into the 'movieDatabaseDataSet3.Movies' table. You can move, or remove it, as needed.
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try { 
            this.Validate();
            this.moviesBindingSource.EndEdit();
            mainForm.database.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill All values");
                Console.WriteLine(ex);
            }

        }

        private void moviesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
