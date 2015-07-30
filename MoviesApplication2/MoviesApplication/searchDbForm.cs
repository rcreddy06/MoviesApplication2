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
    public partial class searchDbForm : Form
    {
        public MovieDatabaseDataContext database = new MovieDatabaseDataContext();

        public searchDbForm()
        {
            MessageBox.Show("- Enter one or more search crieteria."
                   + Environment.NewLine + "- Any combination of search criteria is allowed."
                   + Environment.NewLine + Environment.NewLine + "Example: Enter 'the' in title box, or "
                   + "enter 'comedy' in genre box.", "Search Instructions",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            InitializeComponent();
            this.Text = "Movie Search";
        }

        private void searchDbForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fromYear, toYear;
            fromYear = 0;
            toYear = 9999;


            if (from1Text.Text != "")
                fromYear = Convert.ToInt16(from1Text.Text);
            if (toText.Text != "")
                toYear = Convert.ToInt16(toText.Text);

            String actor = actorText.Text;
            String director = directorText.Text;
            String partialTitle = titleText.Text;

            var movie =
               from m in database.Movies
               from p in database.Persons
               from pr in database.PersonRoles
               from g in database.Genres
               from mg in database.MovieGenres
               from pf in database.MoviePersons
               where (partialTitle == "" || m.title.Contains(partialTitle)) &&
               m.releaseYear >= fromYear &&
               m.releaseYear <= toYear &&
               (director == "" || (p.name == director &&
                                           pr.personId == p.personId &&
                                           pr.roleId == 3 &&
                                           m.director == pr.personRolesId)) &&
                (genreText.Text == "" || (mg.movieId == m.movieId &&
                mg.genreId == g.genreId &&
                g.description == genreText.Text)) &&
                (languageText.Text == "" || (languageText.Text == m.language))
               select m.title;

            listBox1.Items.Clear();
            foreach (var a in movie)
                if (!listBox1.Items.Contains(a.ToString()))
                    listBox1.Items.Add(a);

            if (actorText.Text != "")
            {
                var moviesByActrors = from m in database.Movies
                                      from p in database.Persons
                                      from pr in database.PersonRoles
                                      from g in database.Genres
                                      from pf in database.MoviePersons

                                      where (p.name.Trim() == actorText.Text &&
                                      p.personId == pr.personId &&
                                      (pr.roleId == 1 || pr.roleId == 2) &&
                                       pr.personRolesId == pf.personRolesId &&
                                       pf.movieId == m.movieId)
                                      select m.title;
                List<String> movieList = new List<String>();

                foreach (var elem in listBox1.Items)
                    if (moviesByActrors.Contains(elem))
                        movieList.Add((String)elem);


                listBox1.Items.Clear();
                foreach (var item in movieList)
                    listBox1.Items.Add(item);

            }
            moviesLabel.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = listBox1.GetItemText(listBox1.SelectedItem);

            var movies = from movieName in database.Movies
                         where movieName.title == value
                         select movieName;

            Movy movie = movies.First();
            moviesLabel.Text = "Title: " + movie.title + "\n" + "Release Year: " + movie.releaseYear + "\n" + "Language: " + movie.language + "\n";

            var genresID = from genreId in database.MovieGenres
                           where genreId.movieId == movie.movieId
                           select genreId;

            moviesLabel.Text += "Genre: ";
            foreach (var g in genresID)
            {
                var genres = from genre in database.Genres
                             where genre.genreId == g.genreId
                             select genre;

                Genre gg = genres.First();
                moviesLabel.Text += gg.description + ",";
            }
            moviesLabel.Text += "\n";

            var directorID = from id in database.Persons
                             where id.personId == movie.director
                             select id;
            moviesLabel.Text += "Director: " + directorID.First().name + "\n";

            var personNames = from p in database.Persons
                              from pr in database.PersonRoles
                              from pf in database.MoviePersons
                              where pr.personRolesId == pf.personRolesId &&
                              pf.movieId == movie.movieId &&
                              p.personId == pr.personId
                              select p.name;
            moviesLabel.Text += "Actor/Actresses: ";

            foreach (var name in personNames)
                moviesLabel.Text += name.Trim() + ", ";                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actorText.Clear();
            directorText.Clear();
            from1Text.Clear();
            genreText.Clear();
            languageText.Clear();
            titleText.Clear();
            listBox1.Items.Clear();
            moviesLabel.Text = "";     
        }
    }
}
