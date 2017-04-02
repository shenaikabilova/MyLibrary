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
    public partial class AuthorView : Form {
        public AuthorView() {
            InitializeComponent();
        }

        private void bAuthorAdd(object sender, MouseEventArgs e) {
            Author author = new Author();
            author.setAuthorName(tbAuthorName.Text);
            author.setAuthorFamily(tbAuthorFamily.Text);
            MyLibraryDAO<Author> addAuthor = new AuthorDAOImpl();
            addAuthor.add(author);
        }

        private void exit_click(object sender, MouseEventArgs e) {
            this.Hide();
            Library f = new Library();
            f.Show();
        }
    }
}
