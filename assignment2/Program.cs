using assignment1;
using DAL;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            List<Customer> listCustomer = new List<Customer>();
            CustomerDAO customer = new CustomerDAO();

            listCustomer = customer.GetAll();

            foreach (Customer customer1 in listCustomer)
            {
                Console.WriteLine($"{customer1.FullName} ({customer1.EmailAddress})");
            }

            Console.WriteLine();

            Console.Write("Enter customer id: ");
            int customerId = int.Parse(Console.ReadLine());

            if (customerId > listCustomer.Count)
            {
                Console.WriteLine($"No customer with id {customerId}");
            }
            else
            {
                Console.WriteLine(customer.GetById(customerId));
            }

            Console.WriteLine();

            List<Book> listBooks = new List<Book>();
            BookDAO bookDAO = new BookDAO();

            listBooks = bookDAO.GetAll();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Book book in listBooks)
            {
                Console.WriteLine($"'{book.Title}' by {book.Author}");
            }

            Console.WriteLine();

            Console.Write("Enter book id: ");
            int bookID = int.Parse(Console.ReadLine());

            if (bookID > listBooks.Count)
            {
                Console.WriteLine($"No book with id {bookID}");
            }
            else
            {
                Console.WriteLine(bookDAO.GetById(bookID));
            }

            Console.ResetColor();
        }
    }
}