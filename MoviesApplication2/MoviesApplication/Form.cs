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
    public partial class Form1 : Form
    {
        public MovieDatabaseDataContext database = new MovieDatabaseDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActorRelation rInfo = new ActorRelation(this);
            rInfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovieInfo mInfo = new MovieInfo(this);
            mInfo.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovieActorRelation marInfo = new MovieActorRelation(this);
            marInfo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenreInfo gInfo = new GenreInfo(this);
            gInfo.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Instructions info = new Instructions(this);
            info.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
