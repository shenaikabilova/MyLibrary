using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyLibrary {
    class BookDAOImpl : MyLibraryDAO<Book> {
        private const String conn = "server=localhost;user=root;database=MyLibrary;port=3306;password=123456;";
        private String query;

        public void add(Book addNewObj) {
            MySqlConnection connection = new MySqlConnection(conn);
            try {
                connection.Open();

                query = "INSERT INTO Book(bookName, bookYear, bookTimeRead, fkAuthor, fkGenre) VALUES (@bookName, @bookYear, @bookTimeRead, @fkAuthor, @fkGenre)"; 
                
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookName", addNewObj.getBookName());
                command.Parameters.AddWithValue("@bookYear", addNewObj.getYear());
                command.Parameters.AddWithValue("@bookTimeRead", addNewObj.getTimeRead());
                command.Parameters.AddWithValue("@fkAuthor", addNewObj.getAuthorID());
                command.Parameters.AddWithValue("@fkGenre", addNewObj.getGenreID());

                command.ExecuteNonQuery();

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public void update(Book updateObj){
            MySqlConnection connection = new MySqlConnection(conn);
            try
            {
                connection.Open();

                query = "UPDATES Book SET bookName=@bookName, bookYear=@bookYear, bookTimeRead=@bookTimeRead, fkAuthor=@fkAuthor, fkGenre=@fkGenre WHERE authorId=" + updateObj.getBookID();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookName", updateObj.getBookName());
                command.Parameters.AddWithValue("@bookYear", updateObj.getYear());
                command.Parameters.AddWithValue("@bookTimeRead", updateObj.getTimeRead());
                command.Parameters.AddWithValue("@fkAuthor", updateObj.getAuthorID());
                command.Parameters.AddWithValue("@fkGenre", updateObj.getGenreID());

                command.ExecuteReader();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public void delete(int id) {
            MySqlConnection connection = new MySqlConnection(conn);
            try
            {
                connection.Open();

                query = "DELETE Book WHERE authorID= " + id;
                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public Book searchByID(int id) {
            Book book = null; ;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT bookName, bookYear, bookTimeRead FROM book WHERE bookID= " + id;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    String bookName = reader["bookName"].ToString();
                    int bookYear = Convert.ToInt32(reader["bookYear"]);
                    int bookTimeRead = Convert.ToInt32(reader["bookTimeRead"]);
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return book;
        }

        public List<Book> searchAll() {
            List<Book> books = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try
            {
                connection.Open();

                query = "SELECT book.bookID, book.bookName, book.bookYear, book.bookTimeRead, " +
                        "CONCAT(author.authorName, ' ', author.authorFamily), " +  
                        "genre.genreName FROM book" +
                        "join author on book.fkAuthor = author.authorID" +
                        "join genre on book.fkGenre = genre.genreID";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book();
                    book.setBookID(reader["bookID"].ToString());
                    book.setBookName(reader["bookName"].ToString());
                    book.setYear(Convert.ToInt32(reader["bookYear"]));
                    book.setTimeRead(Convert.ToInt32(reader["bookTimeRead"]));
                    book.setAuthor(reader["fkAuthor"].ToString());
                    book.setGenreID(reader["fkGenre"].ToString());

                    books.Add(book);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return books;
        }

        public List<Book> searchAllByID(int id) {
            return null;
        }
    }
}
