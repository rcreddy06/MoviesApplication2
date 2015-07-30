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
    public partial class ActorRelation : Form
    {
        Form1 mainForm;
        public ActorRelation(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            personBindingSource.DataSource      = mainForm.database.Persons;
            roleBindingSource.DataSource        = mainForm.database.Roles;
            personRolesBindingSource.DataSource = mainForm.database.PersonRoles;

        }

        private void ActorRelation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Role' table. You can move, or remove it, as needed.
            this.personRolesTableAdapter.Fill(this.movieDatabaseDataSet.PersonRoles);
            //this.personTableAdapter.Fill(this.movieDatabaseDataSet.Person);
            this.roleTableAdapter.Fill(this.movieDatabaseDataSet.Role);
            // TODO: This line of code loads data into the 'movieDatabaseDataSet2.Person' table. You can move, or remove it, as needed.

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try { 
            this.Validate();
            this.personBindingSource.EndEdit();
            mainForm.database.SubmitChanges();
                 }
            catch (Exception ex)
            {
                MessageBox.Show("Fill All values");
                Console.WriteLine(ex);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.personRolesBindingSource.EndEdit();
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
