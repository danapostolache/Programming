using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Book
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author}";
        }
    }

}