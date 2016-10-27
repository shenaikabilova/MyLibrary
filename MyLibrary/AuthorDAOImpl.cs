using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyLibrary {
    class AuthorDAOImpl : MyLibraryDAO<Author> {
        private const String conn = "server=localhost;user=root;database=MyLibrary;port=3306;password=123456;";
        private String query;

        public void add(Author addNewObj) {
            MySqlConnection connection = new MySqlConnection(conn);
            try {
                connection.Open();

                query = "INSERT INTO Author(authorName, authorFamily) VALUES(@authorName, @authorFamily)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@authorName", addNewObj.getAuthorName());
                command.Parameters.AddWithValue("@authorFamily", addNewObj.getAuthorFamily());   
     
                command.ExecuteNonQuery();

            } catch (Exception e){
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public void update(Author updateObj) {
            MySqlConnection connection = new MySqlConnection(conn);
            try {
                connection.Open();

                query = "UPDATES Author SET authorName=@authorName, authorFamily=@authorFamily WHERE authorId=" + updateObj.getAuthorID();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@authorName", updateObj.getAuthorName());
                command.Parameters.AddWithValue("@authorFamily", updateObj.getAuthorFamily());

                command.ExecuteReader();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            connection.Close();   
        }

        public void delete(int id) {
            MySqlConnection connection = new MySqlConnection(conn);
            try {
                connection.Open();

                query = "DELETE Author WHERE authorID= " + id;
                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public Author searchByID(int id) {
            Author author = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT authorName, authorFamily FROM author WHERE authorID= " + id;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    author = new Author();
                    author.setAuthorID(Convert.ToInt32(reader["authorID"]));
                    author.setAuthorName(reader["authorName"].ToString());
                    author.setAuthorFamily(reader["authorFamily"].ToString());
                }

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return author;
        }

        public List<Author> searchAll() {
            List<Author> authors = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

              //  query = "SELECT book.bookID, book.bookName, book.bookYear, book.bookTimeRead from book join author on book.fkAuthor = author.authorID join genre on book.fkGenre = genre.genreID where author.authorID = ";
                query = "SELECT authorID, authorName, authorFamily FROM Author";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader =  command.ExecuteReader();
                authors = new List<Author>();

                while (reader.Read()) {
                    Author author = new Author();
                    author.setAuthorID(reader.GetInt32("authorID"));
                    author.setAuthorName(reader.GetString("authorName"));
                    author.setAuthorFamily(reader.GetString("authorFamily"));

                    authors.Add(author);
                }

                return authors;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return authors;
        }

        public List<Author> searchAllByID(int id) {
            List<Author> authors = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT book.bookID, book.bookName, book.bookYear, book.bookTimeRead, book.fkGenre FROM book " +
                    "join author on book.fkAuthor = author.authorID" +
                    "join genre on book.fkGenre = genre.genreID WHERE mylibrary.author.authorID = " + id;

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                authors = new List<Author>();

                while (reader.Read()) {
                    Book book = new Book();
                    book.setBookID(reader.GetInt32("bookID"));
                    book.setBookName(reader.GetString("bookName"));
                    book.setYear(reader.GetInt32("bookYear"));
                    book.setAuthorID(id);
                    book.setGenreID(reader.GetInt32("fkGenre"));
                }

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return authors;
        }
    }
}
