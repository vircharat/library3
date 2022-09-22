using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementBusinesss;
using LibraryManagementDataa;
using LibraryManagementEntity;

namespace LibraryManagementBusinesss
{
    public  class BookBLL
    {
        public string AddBookBLL(Book book)
        { 
           BookDAL bookDALObj=new BookDAL();

            string  msg=bookDALObj.AddBooksDAL(book);
            return msg;
        }
        private void BookValidation()
        {

        }
        public void GetAllBookBLL()
        {

        }

        public string RemoveBookBLL(int BookId)
        {
            BookDAL bookDALObj = new BookDAL();

            string msg = bookDALObj.RemoveBooksDAL(BookId);
            return msg;

        }

        public string UpdateBookBLL(Book book)
        {
            BookDAL bookDALObj = new BookDAL();

            string msg = bookDALObj.UpdaeBooksDAL(book);
            return msg;

        }
    }
}
