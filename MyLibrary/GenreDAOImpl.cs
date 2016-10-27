using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyLibrary {
    class GenreDAOImpl : MyLibraryDAO<Genre> {
        private const String conn = "server=localhost;user=root;database=MyLibrary;port=3306;password=123456;";
        private String query;

        public void add(Genre addNewObj) {
            MySqlConnection connection = new MySqlConnection(conn);
            try {
                connection.Open();

                query = "INSERT INTO Genre(genreName) VALUES(@genreName)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@genreName", addNewObj.getGenre());

                command.ExecuteNonQuery();

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public void update(Genre updateObj){
            MySqlConnection connection = new MySqlConnection(conn);
            try {
                connection.Open();

                query = "UPDATES Genre SET genreName=@genreName WHERE genreId=" + updateObj.getGenreID();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@genreName", updateObj.getGenre());

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

                query = "DELETE Book WHERE authorID= " + id;
                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();

            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            connection.Close();
        }

        public Genre searchByID(int id) {
            Genre genre = null; ;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT genreName FROM genre WHERE bookID= " + id;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    genre = new Genre();
                    genre.setGenre(reader["genreName"].ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return genre;
        }

        public List<Genre> searchAll() {
            List<Genre> genres = null;
            MySqlConnection connection = new MySqlConnection(conn);

            try {
                connection.Open();

                query = "SELECT genreID, genreName FROM genre";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                genres = new List<Genre>();

                while (reader.Read()) {
                    Genre genre = new Genre();
                    genre.setGenreID(reader.GetInt32("genreID"));
                    genre.setGenre(reader["genreName"].ToString());

                    genres.Add(genre);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return genres;
        }

        public List<Genre> searchAllByID(int id) {
            return null;
        }
    }
}
