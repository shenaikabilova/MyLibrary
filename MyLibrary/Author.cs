using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    class Author {
        private String authorID;
        private String authorName;
        private String authorFamily;

        public String getAuthorID() {
            return authorID;
        }

        public void setAuthorID(String authorID) {
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