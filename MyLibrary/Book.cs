using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    class Book {
        private String bookID;
        private String bookName;
        private int year;
        private int timeRead;
        private Author author;
        private Genre genre;
//        private int authorID;
//        private int genreID;

        public String getBookID() {
            return bookID;
        }

        public void setBookID(String bookID) {
            this.bookID = bookID;
        }

        public String getBookName() {
            return bookName;
        }

        public void setBookName(String bookName) {
            this.bookName = bookName;
        }

        public int getYear() {
            return year;
        }

        public void setYear(int year) {
            this.year = year;
        }

        public int getTimeRead() {
            return timeRead;
        }

        public void setTimeRead(int timeRead) {
            this.timeRead = timeRead;
        }

        public Author getAuthorID() {
            return author;
        }

        public void setAuthor (Author author) {
            this.author = author;
        }

        public Genre getGenreID() {
            return genre;
        }

        public void setGenreID(Genre genre) {
            this.genre = genre;
        }

/*        public void setAuthorID(int authorID){
            this.authorID = authorID;
        }

        public void setGenreID(int genreID) {
            this.genreID = genreID;
        }

        public int getAuthor() {
            return this.authorID;
        }

        public int getGenre() {
            return this.genreID;
        }*/
    }
}