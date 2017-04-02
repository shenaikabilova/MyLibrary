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
    public partial class Library : Form {
        public Library() {
            InitializeComponent();
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            AuthorView authorView = new AuthorView();
            authorView.Show();
        }

        private void GenreToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            GenreView genreView = new GenreView();
            genreView.Show();
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            BookView bookView = new BookView();
            bookView.Show();
        }

        private void ByAuthorToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            SearchByAuthor searchByAuthor = new SearchByAuthor();
            searchByAuthor.Show();
        }

        private void AllToolStripMenuItem_Click(object sender, EventArgs e) {
            BookDAO bookDao = new BookDAOImpl();
            List<Book> books = bookDao.searchAll();
            this.Hide();
            SearchResult result = new SearchResult(books);
            result.Show();
        }

        private void ByGenreToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            SearchByGenre searchByGenre = new SearchByGenre();
            searchByGenre.Show();
        }
    }
}
