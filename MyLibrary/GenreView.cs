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
    public partial class GenreView : Form {
        public GenreView() {
            InitializeComponent();
        }

        private void bGenreAdd(object sender, MouseEventArgs e){
            Genre genre = new Genre();
            genre.setGenre(tbGenre.Text);
            MyLibraryDAO<Genre> dao = new GenreDAOImpl();
            dao.add(genre);
        }

        private void exit_click(object sender, MouseEventArgs e) {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
