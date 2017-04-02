using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyLibrary {
    class BookDAOImpl : BookDAO {
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

        public void delete(String id) {
            MySqlConnection connection = new MySqlConnection(conn);
            try
            {
                connection.Open();

                query = "DELETE Book WHERE authorID= '" + id + "'";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public List<Book> searchAll() {
            List<Book> books = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try
            {
                connection.Open();
                
                query = "SELECT book.bookID, book.bookName, book.bookYear, book.bookTimeRead, book.fkAuthor, book.fkGenre, " +
                        "CONCAT(author.authorName, ' ', author.authorFamily) as author, " +  
                        "genre.genreName as genre FROM book " +
                        "join author on book.fkAuthor = author.authorID " +
                        "join genre on book.fkGenre = genre.genreID";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                books = new List<Book>();

                while (reader.Read())
                {
                    Book book = new Book();
                    book.setBookID(Convert.ToInt32(reader["bookID"]));
                    book.setBookName(reader["bookName"].ToString());
                    book.setYear(Convert.ToInt32(reader["bookYear"]));
                    book.setTimeRead(Convert.ToInt32(reader["bookTimeRead"]));
                    book.setAuthorID(Convert.ToInt32(reader["fkAuthor"]));
                    book.setAuthorName(reader["author"].ToString());
                    book.setGenreID(Convert.ToInt32(reader["fkGenre"]));
                    book.setGenre(reader["genre"].ToString());

                    books.Add(book);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return books;
        }

        public List<Book> searchByAuthorID(int id) {
            List<Book> books = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT  mylibrary.book.bookID,  mylibrary.book.bookName,  mylibrary.book.bookYear, " +
                        "mylibrary.book.bookTimeRead, fkAuthor, fkGenre, " +
                        "CONCAT(mylibrary.author.authorName, ' ', mylibrary.author.authorFamily) as author, " +
                        "mylibrary.genre.genreName as genre FROM mylibrary.book " +
                        "join mylibrary.author on mylibrary.book.fkAuthor = author.authorID " +
                        "join mylibrary.genre on mylibrary.book.fkGenre = genre.genreID " +
                        "WHERE mylibrary.author.authorID =  " + id;

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                books = new List<Book>();

                while (reader.Read()) {
                    Book book = new Book();
                    book.setBookID(Convert.ToInt32(reader["bookID"]));
                    book.setBookName(reader["bookName"].ToString());
                    book.setYear(Convert.ToInt32(reader["bookYear"]));
                    book.setTimeRead(Convert.ToInt32(reader["bookTimeRead"]));
                    book.setAuthorID(Convert.ToInt32(reader["fkAuthor"]));
                    book.setAuthorName(reader["author"].ToString());
                    book.setGenreID(Convert.ToInt32(reader["fkGenre"]));
                    book.setGenre(reader["genre"].ToString());

                    books.Add(book);
                }

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return books;
        }

        public List<Book> searchByGenreID(int id) {
            List<Book> books = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT mylibrary.book.bookID,  mylibrary.book.bookName,  mylibrary.book.bookYear, " +
                        "mylibrary.book.bookTimeRead, fkAuthor, fkGenre, " +
                        "CONCAT(mylibrary.author.authorName, ' ', mylibrary.author.authorFamily) as author, " +
                        "mylibrary.genre.genreName as genre FROM mylibrary.book " +
                        "join mylibrary.author on mylibrary.book.fkAuthor = author.authorID " +
                        "join mylibrary.genre on mylibrary.book.fkGenre = genre.genreID " +
                        "WHERE mylibrary.genre.genreID =  " + id;

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                books = new List<Book>();

                while (reader.Read()) {
                    Book book = new Book();
                    book.setBookID(Convert.ToInt32(reader["bookID"]));
                    book.setBookName(reader["bookName"].ToString());
                    book.setYear(Convert.ToInt32(reader["bookYear"]));
                    book.setTimeRead(Convert.ToInt32(reader["bookTimeRead"]));
                    book.setAuthorID(Convert.ToInt32(reader["fkAuthor"]));
                    book.setAuthorName(reader["author"].ToString());
                    book.setGenreID(Convert.ToInt32(reader["fkGenre"]));
                    book.setGenre(reader["genre"].ToString());

                    books.Add(book);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return books;
        }
    }
}