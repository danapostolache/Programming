using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment1;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class BookDAO
    {
        private SqlConnection dbConnection;

        public BookDAO()
        {
            string connString = ConfigurationManager
                                    .ConnectionStrings["dbString"]
                                    .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book book = ReadBookData(reader);
                books.Add(book);
            }
            reader.Close();
            dbConnection.Close();
            return books;
        }

        private Book ReadBookData(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            return new Book(id, title, author);
        }

        public Book GetById(int bookId)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Id=@Id", dbConnection);

            cmd.Parameters.AddWithValue("@Id", bookId);

            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;

            if (reader.Read())
            {
                book = ReadBookData(reader);
            }

            reader.Close();
            dbConnection.Close();

            return book;
        }
    }
}
