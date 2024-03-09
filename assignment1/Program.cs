using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
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
            int idLionel = 1;                                         
            string firstNameLionel = "Lionel";
            string lastNameLionel = "Messi";
            string emailLionel= "lionelmessi@hotmail.com";
            Customer customerLionel = new Customer(idLionel, firstNameLionel, lastNameLionel, emailLionel);

            int idDon = 2;
            string firstNameDon = "Don";
            string lastNameDon = "Henley";
            string emailDon = "donhenley@gmail.com";
            Customer customerDon = new Customer(idDon, firstNameDon, lastNameDon, emailDon);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing customers");
            Console.ResetColor();

            Console.WriteLine(customerLionel.ToString());
            Console.WriteLine(customerDon.ToString());

            int bookIdHarryPotter = 0;                                                    
            string titleHarryPotter = "Harry Potter and the Prisoner of Azkaban";
            string authorHarryPotter = "J.K. Rowling";
            Book bookHarryPotter = new Book(bookIdHarryPotter, titleHarryPotter, authorHarryPotter);

            int bookIdDaVinceCode = 1;
            string titleDaVinceCode = "The Da Vince Code";
            string authorDaVinceCode = "Dan Brown";
            Book bookDaVinceCode = new Book(bookIdDaVinceCode, titleDaVinceCode, authorDaVinceCode);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing books");
            Console.ResetColor();

            Console.WriteLine(bookHarryPotter.ToString());
            Console.WriteLine(bookDaVinceCode.ToString());

            Console.WriteLine();                                     
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing reservations");
            Console.ResetColor();


            int idReservationLionel = 1;
            int idReservationDon = 2;

            Reservation rezervation1 = new Reservation(idReservationLionel, customerLionel, bookDaVinceCode);
            Reservation rezervation2 = new Reservation(idReservationDon, customerDon, bookDaVinceCode);


            Console.WriteLine(rezervation1.ToString());
            Console.WriteLine(rezervation2.ToString());
        }
    }
}