using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    class Author {
        private int authorID;
        private String authorName;
        private String authorFamily;

        public int getAuthorID() {
            return authorID;
        }

        public void setAuthorID(int authorID) {
            this.authorID = authorID;
        }

        public String getAuthorName() {
            return authorName;
        }

        public void setAuthorName(String authorName) {
            this.authorName = authorName;
        }

        public String getAuthorFamily() {
            return authorFamily;
        }

        public void setAuthorFamily(String authorFamily) {
            this.authorFamily = authorFamily;
        }
    }
}