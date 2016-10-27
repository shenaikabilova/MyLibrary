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
        public SearchByAuthor() {
            InitializeComponent();
        }

        private void searchByAuthor_click(object sender, MouseEventArgs e) {
            MyLibraryDAO<Author> dao = new AuthorDAOImpl();
            List<Author> author = dao.searchAll();
            
            foreach (Author a in author) {
                if(tbName.Text.Equals(a.getAuthorName() + " " + a.getAuthorFamily())) {
                    this.Hide();
                    SearchResult result = new SearchResult();
                    result.Show();
                }
             }
        }
    }
}