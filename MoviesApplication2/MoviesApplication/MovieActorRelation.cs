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
    public partial class MovieActorRelation : Form
    {
        Form1 mainForm;
        public MovieActorRelation(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            moviePersonBindingSource.DataSource = mainForm.database.MoviePersons;
        }

        private void MovieActorRelation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.MoviePerson' table. You can move, or remove it, as needed.
            //this.moviePersonTableAdapter.Fill(this.movieDatabaseDataSet.MoviePerson);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try { 
            this.Validate();
            this.moviePersonBindingSource.EndEdit();
            mainForm.database.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill All values");
                Console.WriteLine(ex);
            }
        }
    }
}
