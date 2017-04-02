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
    public partial class SearchByGenre : Form {
        private Genre genre;
        List<Genre> genres;

        public SearchByGenre() {
            InitializeComponent();
        }

        private void SearchByGenre_Load(object sender, EventArgs e) {
            MyLibraryDAO<Genre> dao = new GenreDAOImpl();
            genres = dao.searchAll();

            foreach (Genre g in genres) {
                genre = new Genre();
                genre.setGenreID(g.getGenreID());
                genre.setGenre(g.getGenre());

                cbGenre.Items.Add(genre.getGenre());
            }
        }

        private void searchByGenre_click(object sender, MouseEventArgs e) {
            foreach (Genre genre in genres){
                if (cbGenre.SelectedItem.Equals(genre.getGenre())){
                    BookDAO bookDao = new BookDAOImpl();
                    List<Book> books = bookDao.searchByGenreID(genre.getGenreID());
                    this.Hide();
                    SearchResult result = new SearchResult(books);
                    result.Show();
                }
            }
        }

        private void bGenreExit_Click(object sender, EventArgs e){
            this.Hide();
            Library f = new Library();
            f.Show();
        }
    }
}
