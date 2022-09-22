using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class Book
    {
        public string BookAuthor { get; set; }

        public int BookCopies { get; set; }

        public int BookId { get; set; }
        
        public string BookName { get; set; }

        public Book()
        {

        }
        public Book(string BookAuthor,int BookCopies,int BookId,string Bookname)
        {
           this.BookAuthor=BookAuthor;
           this.BookCopies = BookCopies;
           this.BookId = BookId;
           this.BookName = Bookname;
        }
    }
}
