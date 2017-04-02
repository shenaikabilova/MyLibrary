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
    public partial class SearchByAuthor : Form {
        private Author author;
        List<Author> authors;
        
        public SearchByAuthor() {
            InitializeComponent();
        }


        private void SearchByAuthor_Load(object sender, EventArgs e) {
            MyLibraryDAO<Author> dao = new AuthorDAOImpl();
            authors = dao.searchAll();

            foreach (Author a in authors) {
                author = new Author();
                author.setAuthorID(a.getAuthorID());
                author.setAuthorName(a.getAuthorName());
                author.setAuthorFamily(a.getAuthorFamily());

                cbAuthor.Items.Add(author.getAuthorName() + " " + author.getAuthorFamily());
            }
        }

        private void searchByAuthor_click(object sender, MouseEventArgs e) {
            foreach (Author author in authors) {
                if (cbAuthor.SelectedItem.Equals(author.getAuthorName() + " " + author.getAuthorFamily())) {
                    BookDAO bookDao = new BookDAOImpl();
                    List<Book> books = bookDao.searchByAuthorID(author.getAuthorID());
                    this.Hide();
                    SearchResult result = new SearchResult(books);
                    result.Show();
                }
            }
        }

        private void bExit_Click(object sender, EventArgs e) {
            this.Hide();
            Library f = new Library();
            f.Show();
        }
    }
}