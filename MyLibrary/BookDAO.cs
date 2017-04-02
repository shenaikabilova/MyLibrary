﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary {
    interface BookDAO {
        void add(Book addNewObj);
        void update(Book updateObj);
        void delete(String id);
        List<Book> searchAll();
        List<Book> searchByAuthorID(int id);
        List<Book> searchByGenreID(int id);
    }
}
