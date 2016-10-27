using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    class Genre {
        private String genreID;
        private String genre;

        public String getGenreID() {
            return genreID;
        }

        public void setGenreID(String genreID) {
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