using LibraryManagementDataa;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinesss
{
    public class UserBLL
    {
        private string userDAL;

        public bool UserLogin(string userEmail,string userPassword)
        {
            bool flag = false;
            UserDAL userDALObj = new UserDAL();
            // adminDALObj.GetAllAdminsDAL();
            List<User> users = userDALObj.GetAllUserssDAL();

            foreach (var item in users)
            {
                if (item.UserEmail == userEmail && item.UserPassword == userPassword)
                {
                    flag = true;

                    break;
                }


            }
            return flag;
        }
        public void AcceptRequestBLL()
        {

        }
        public string AddUsersBLL(User user)
        {
            UserDAL userDALObj = new UserDAL();

            string msg = userDALObj.AddUsersDAL(user);
            return msg;

        }

        public List<User> GetAllUsersBLL()
        {
            UserDAL userDALObj = new UserDAL();
            List<User> users = userDALObj.GetAllUserssDAL();
            return users;

        }

        public void GetReceivedBookBLL()
        {

        }

        public void GetRequestBookBLL()
        {

        }
        public void GetUserIdBLL()
        {

        }

        public string RemoveUsersBLL(int UserId)
        {
            UserDAL userDALObj = new UserDAL();

            string msg = userDALObj.RemoveUsersDAL(UserId);
            return msg;
        }

        public void RequestBookBLL()
        {

        }

        public string UpdateUsersBLL(User user)
        {
            UserDAL userDALObj = new UserDAL();

            string msg = userDALObj.UpdateUsersDAL(user);
            return msg;
        }

        private void UserValidation()
        {
            
        }









    }
}
