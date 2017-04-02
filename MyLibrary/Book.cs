using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    class Book {
        private int bookID;
        private String bookName;
        private int year;
        private int timeRead;
        private int authorID;
        private int genreID;
        private String authorName;
        private String genre;

        public int getBookID() {
            return bookID;
        }

        public void setBookID(int bookID) {
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

        public void setAuthorID(int authorID){
            this.authorID = authorID;
        }

        public void setGenreID(int genreID) {
            this.genreID = genreID;
        }

        public int getAuthorID() {
            return authorID;
        }

        public int getGenreID() {
            return genreID;
        }

        public String getAuthorName() {
            return authorName;
        }

        public void setAuthorName(String authorName) {
            this.authorName = authorName;
        }

        public String getGenre() {
            return genre;
        }

        public void setGenre(String genre) {
            this.genre = genre;
        }
    }
}