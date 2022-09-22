using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace LibraryManagementDataa
{
    public class BookDAL
    {
        List<Book> books;

        public static string sqlcon = "Data Source=VDC01LTC2179;Initial Catalog=LibraryManagementService;Integrated Security=True";
        public string AddBooksDAL(Book book)
        {
            #region connected approach
            /* string msg = "";
             SqlConnection con = new SqlConnection(sqlcon);
             SqlCommand cmd = new SqlCommand("insert into book values('"+book.BookAuthor+"',"+book.BookCopies+","+book.BookId+",'"+book.BookName+"')", con);
             con.Open();
             int row =cmd.ExecuteNonQuery();
             con.Close();
             if (row > 0)
                 msg = "inserted";


             return msg;*/
            #endregion
            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into book values('" + book.BookAuthor + "'," + book.BookCopies + "," + book.BookId + ",'" + book.BookName + "')", con);
            DataTable dt=new DataTable();//only single table is their
            DataSet ds=new DataSet(); //multiple table can be their
            adp.Fill(dt);
            msg = "inserted";
            return msg;
            #endregion

        }

        public List<Book> GetAllBooksDAL()
        {
            #region connected
            /* SqlConnection con = new SqlConnection(sqlcon);
             SqlCommand cmd = new SqlCommand("select * from book", con);
             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             books = new List<Book>();   
             while (dr.Read())
             {
                 books.Add(new Book
                 {
                     BookId = Convert.ToInt32(dr["BookId"]),
                     BookName = dr["BookName"].ToString(),
                     BookAuthor = dr["BookAuthor"].ToString(),
                     BookCopies = Convert.ToInt32(dr["BookCopies"])
                 }) ;
             }

             con.Close();
             return books;*/
            #endregion
            #region  disconnected
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from book", con);

            DataTable dt = new DataTable();
            List<Book> books = new List<Book>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {   for(int i = 0; i < dt.Rows.Count; i++) // rows.count for how many rows in database
                books.Add(new Book
                {
                    BookId = Convert.ToInt32(dt.Rows[i]["BookId"]),
                    BookName = dt.Rows[i]["BookName"].ToString(),
                    BookAuthor = dt.Rows[i]["BookAuthor"].ToString(),
                    BookCopies = Convert.ToInt32(dt.Rows[i]["BookCopies"])
                });
            }
           //how to serialize
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            FileStream fileStream = new FileStream("books.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, books);
            //how to deserialize
            var reader=new StreamReader("books.xml");
            var result=(List<Book>)xmlSerializer.Deserialize(reader);
            return books;
            #endregion

        }

        public string RemoveBooksDAL(int BookId)
        {
            string msg = "";
            Book book = new Book();
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from book where BookId=" + BookId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "deleted sucessfully";
            return msg;

        }
        public string UpdaeBooksDAL(Book book)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand(" update book set BookAuthor='"+book.BookAuthor+"',BookCopies="+book.BookCopies+",BookId= "+ book.BookId+ ",BookName='" + book.BookName + "' where BookId="+book.BookId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "updated sucessfully";
            return msg;

           
            
        }

    }
}
