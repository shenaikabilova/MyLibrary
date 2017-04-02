using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    class Genre {
        private int genreID;
        private String genre;

        public int getGenreID() {
            return genreID;
        }

        public void setGenreID(int genreID) {
            this.genreID = genreID;
        }

        public String getGenre() {
            return genre;
        }

        public void setGenre(String genre) {
            this.genre = genre;
        }
    }
}