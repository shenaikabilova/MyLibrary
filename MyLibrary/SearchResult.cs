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
    public partial class SearchResult : Form {
        private List<Book> books = new List<Book>();

        internal SearchResult(List<Book> books) {
            InitializeComponent();
            this.books = books;
        }

        private void SearchResult_Load(object sender, EventArgs e) {
            BookDAO dao = new BookDAOImpl();
            
            foreach (Book book in books) {
                dataGridViewResult.Rows.Add(book.getBookName(), book.getYear(), book.getTimeRead(), book.getAuthorName(), book.getGenre());
            }
        }
    }
}