using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary{
    interface MyLibraryDAO<E> {
        void add(E addNewObj);
        void update(E updateObj);
        void delete(String id);
        List<E> searchAll();
    }
}