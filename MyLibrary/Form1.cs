using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            AuthorView authorView = new AuthorView();
            authorView.Show();
        }

        private void жанрToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            GenreView genreView = new GenreView();
            genreView.Show();
        }

        private void книгаToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            BookView bookView = new BookView();
            bookView.Show();
        }

        private void поАвторToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            SearchByAuthor searchByAuthor = new SearchByAuthor();
            searchByAuthor.Show();
        }

        private void всичкиToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            SearchResult result = new SearchResult();
            result.Show();
        }
    }
}
