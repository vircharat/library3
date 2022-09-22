using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using LibraryManagementDataa;
using LibraryManagementBusinesss;

namespace Library_management
{
    public class BookPL
    {
        private string book;
       
        public void AddBook()
        {
            Console.WriteLine("Enter Book Details");
            Console.WriteLine("Book Id :");
            int BookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book Name :");
            string BookName = Console.ReadLine();
            Console.Write("Book Author :");
            string BookAuthor = Console.ReadLine();
            Console.Write("Book Copies :");
            int BookCopies = Convert.ToInt32(Console.ReadLine());
            Console.Read();
            Book book = new Book(BookName, BookCopies, BookId, BookAuthor);
           
            BookBLL bookBLLObj = new BookBLL();
            string msg= bookBLLObj.AddBookBLL(book);

            Console.WriteLine(msg);
            Console.Read();





        }

        public void BookSection()
        {
            Console.WriteLine("Welcome to Book Section");
            Console.WriteLine("1)Press 1 to add a Book\n"+"2)Press 2 to update a book\n"+"3)Press 3 to delete a book\n"+"4)Press 4 to show all book\n"+"5)Press 5 to exit\n");

            int codeEntered;
            codeEntered =Convert.ToInt32(Console.ReadLine());
            BookPL bookPLObj = new BookPL();



            switch (codeEntered)
            {
                case 1:
                    bookPLObj.AddBook();
                    break;
                case 2:
                    bookPLObj.UpdateBook();
                    break ;
                case 3:
                    bookPLObj.RemoveBook();
                    break;
                case 4:
                    bookPLObj.GetAllBook();
                    break;
                default:
                    Console.WriteLine("Invalid code");
                    break;


            }

        }
        public void GetAllBook()
        {
            BookDAL bookDALObj=new BookDAL();
            List<Book>book=bookDALObj.GetAllBooksDAL();
            Console.WriteLine("-----------------------BookList------------------------------");
            Console.WriteLine("--Id---------Name--------------Author------------------copies");
            foreach (var item in book)
            {
                Console.WriteLine("\t"+item.BookId+"     \t"+ item.BookName + "    \t" +item.BookAuthor + "    \t" + item.BookCopies);
 

            }
            Console.Read();

        }

        private void GetBookMenu()
        {

        }
        private void RemoveBook()
        {
            BookDAL bookDALObj = new BookDAL();
            Console.WriteLine("Enter Book Details");
            Console.WriteLine("Book Id :");
            int BookId = Convert.ToInt32(Console.ReadLine());
            BookBLL bookBLLObj = new BookBLL();
            string msg = bookBLLObj.RemoveBookBLL(BookId);
            Console.WriteLine(msg);
            Console.Read();

        }

        private void UpdateBook()
        {
            BookDAL bookDALObj = new BookDAL();
            Console.WriteLine("Enter Book Details");
            Console.WriteLine("Book Id :");
            int BookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book Name :");
            string BookName = Console.ReadLine();
            Console.Write("Book Author :");
            string BookAuthor = Console.ReadLine();
            Console.Write("Book Copies :");
            int BookCopies = Convert.ToInt32(Console.ReadLine());
            Console.Read();
            Book book = new Book(BookName, BookCopies, BookId, BookAuthor);
            
            BookBLL bookBLLObj = new BookBLL();
            string msg = bookBLLObj.UpdateBookBLL(book);

            Console.WriteLine(msg);
            Console.Read();


        }

    }
}
