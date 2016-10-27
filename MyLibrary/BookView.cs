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
    public partial class BookView : Form {
        private Author author;
        private List<Author> authors;
        private List<Genre> genres;

        public BookView() {
            InitializeComponent();
            loadAuthor();
            loadGenre();
        }

        private void loadAuthor () {
            MyLibraryDAO<Author> dao = new AuthorDAOImpl();
            authors = dao.searchAll();
            
            foreach (Author a in authors) {
                author = new Author();
                author.setAuthorID(a.getAuthorID());
                author.setAuthorName(a.getAuthorName());
                author.setAuthorFamily(a.getAuthorFamily());

                cbBookAuthor.Items.Add(author.getAuthorName() + " " + author.getAuthorFamily());
            }
        }

        private void loadGenre() {
            MyLibraryDAO<Genre> dao = new GenreDAOImpl();
            genres = dao.searchAll();
            Genre genre;

            foreach (Genre g in genres) {
                genre = new Genre();
                genre.setGenreID(g.getGenreID());
                genre.setGenre(g.getGenre());

                cbGenre.Items.Add(genre.getGenre());
            }
        }

        private void bookAdd_click(object sender, MouseEventArgs e) {
            MyLibraryDAO<Book> addBook = new BookDAOImpl();
            Book book = new Book();
            book.setBookName(tbBookName.Text);
            book.setYear(Int32.Parse(tbBookYear.Text));
            book.setTimeRead(UInt16.Parse(tbTimeRead.Text));

            foreach (Author a in authors) {
                if (cbBookAuthor.Text.Equals(a.getAuthorName() + " " + a.getAuthorFamily())) {
                    book.setAuthorID(a.getAuthorID());
                }
            }

            foreach (Genre g in genres) {
                if(cbGenre.Text.Equals(g.getGenre())) {
                    book.setGenreID(g.getGenreID());
                   // book.setGenreID(Convert.ToInt32(g.getGenreID()));
                }
            }

            addBook.add(book);
        }

        private void bookExit_click(object sender, MouseEventArgs e) {
            String id = cbBookAuthor.Text;

            foreach (Author s in authors) {
                if (cbBookAuthor.Text.Equals(s.getAuthorName() + " " + s.getAuthorFamily())) {
                    MessageBox.Show("", s.getAuthorID().ToString());
                }
            }

        }

    }
}