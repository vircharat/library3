using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace LibraryManagementDataa
{
    public class UserDAL
    {
        public List<ReceivedBook> receivedBooks = new List<ReceivedBook>();

        public List<RequestedBook> requestedBooks = new List<RequestedBook>();

        public List<User> users = new List<User>();
       

        public static string sqlcon = "Data Source=VDC01LTC2179;Initial Catalog=LibraryManagementService;Integrated Security=True";
        public void AcceptRequestDAL()
        {

        }
        public string AddUsersDAL(User user)
        {

            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into User_tbl values('"+user.UserEmail+"',"+user.UserId+",'"+ user.UserName+"','" + user.UserPassword+ "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "user added successfully";
               return msg;
        }
        public void DeleteReceivedDAL()
        {

        }

        public List<User> GetAllUserssDAL()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from User_tbl", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            users = new List<User>();
            while (dr.Read())
            {
                users.Add(new User
                {
                    UserId = Convert.ToInt32(dr["UserId"]),
                    UserName = dr["UserName"].ToString(),
                    UserPassword= dr["UserPassword"].ToString(),
                    UserEmail = dr["UserEmail"].ToString()
                });
            }

            con.Close();
            return users;

        }

        public void GetReceivedBookDAL()
        {

        }

        public void GetRequestBookDAL()
        {

         }
        public string RemoveUsersDAL(int UserId)
        {
            string msg = "";
            User user = new User();
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from User_tbl where UserId=" + UserId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "deleted user sucessfully";
            return msg;
        }
        public void RequestBookDAL()
        {

        }

        public void UsersDAL()
        {

        }

        public string  UpdateUsersDAL(User user)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand(" update User_tbl set UserEmail='" + user.UserEmail + "',UserId=" + user.UserId + ",UserName= '"+ user.UserName +"',UserPassword='" + user.UserPassword + "' where UserId=" + user.UserId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "user updated sucessfully";
            return msg;



        }

    }
}
