using LibraryManagementBusinesss;
using LibraryManagementDataa;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class UserPL
    {
        public string user;

        UserDAL userDALObj=new UserDAL();
        public void AddUser()
        {
            User user = new User();
            Console.WriteLine("Enter user details");
            Console.Write("User Id :");
            user.UserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Name :");
            user.UserName= Console.ReadLine();
            Console.Write("User Email :");
            user.UserEmail = Console.ReadLine();
            Console.Write("User Password :");
            user.UserPassword = Console.ReadLine();
            userDALObj.AddUsersDAL(user); 
            
        }
        public void DeleteReceive()
        {

        }
        public void GetAllUser()
        {   UserBLL userBLLObj = new UserBLL();
            List < User >users= userBLLObj.GetAllUsersBLL();
            Console.WriteLine("-------------------------------UsersList----------------------------");
            Console.WriteLine("--Id-----------Name--------Email-------------------Password---------");
            foreach (var item in users)
            {

                Console.WriteLine("  "+item.UserId+" \t"+ item.UserName+" \t"+ item.UserEmail+" \t"+ item.UserPassword);
                
            }

        }
        public void GetReceivedBook()
        {

        }
        public void GetRequestBook()
        {

        }

        public void GetUserHomeMenu()
        {



        }

        public void GetUserMenu()
        {

        }

        public void GetUserReceivedBook()
        {

        }
        public void GetUserRequestBook()
        {

        }

        public void ReceiveSection()
        {

        }
        public void RemoveUser()
        {
            UserDAL userDALObj = new UserDAL();
            Console.WriteLine("Enter user Details");
            Console.WriteLine("User Id :");
            int UserId = Convert.ToInt32(Console.ReadLine());
            UserBLL userBLLObj = new UserBLL();
            string msg = userBLLObj.RemoveUsersBLL(UserId);
            Console.WriteLine(msg);
            Console.Read();

        }

        public void RequestBook()
        {

        }

        public void RequestSection()
        {

        }
        
        public void UpdateUser()
        {
            User user = new User();
            Console.WriteLine("Enter user details");
            Console.Write("User Id :");
            user.UserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Name :");
            user.UserName = Console.ReadLine();
            Console.Write("User Email :");
            user.UserEmail = Console.ReadLine();
            Console.Write("User Password :");
            user.UserPassword = Console.ReadLine();
           
            Console.Read();
            

            UserBLL userBLLObj = new UserBLL();
            string msg = userBLLObj.UpdateUsersBLL(user);

            Console.WriteLine(msg);
            Console.Read();

        }
        public void UserHomeSection()
        {
 
        }

        public void UserLogin()
        {
            string UserEmail;
            string UserPassword;
            Console.Write("Email :");
            UserEmail = Console.ReadLine();
            Console.Write("Password :");
            UserPassword = Console.ReadLine();
            UserBLL userBLLObj = new UserBLL();

            bool flag = userBLLObj.UserLogin(UserEmail, UserPassword);
            if (flag)
            {
                Console.WriteLine("Logged in Successfully as user");

            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }
        }

        public bool UserSection(bool flag)
        {
            Console.WriteLine("Welcome-to-User-Section");
            int codeentered;
            // int codebooksection, usersection, requestsection, acceptedsection, logout;
            Console.WriteLine("Press 1 to add a user");
            Console.WriteLine("Press 2 to update a user");
            Console.WriteLine("Press 3 to delete a user");
            Console.WriteLine("Press 4 to show all user");
            Console.WriteLine("Press 5 to exit");
            codeentered = Convert.ToInt32(Console.ReadLine());
            UserPL userPLObj = new UserPL();
            switch (codeentered)
            {
                case 1:
                    
                    userPLObj.AddUser();
                    return true;
                    break;
                case 2:
                    userPLObj.UpdateUser();
                    return true;
                    break;
                case 3:
                    userPLObj.RemoveUser();
                    return true;
                    break;
                case 4:
                    userPLObj.GetAllUser();
                    return true;
                    break;
                case 5:
                    flag = false;
                    return flag;
                    break;
                default:
                    Console.WriteLine("invalid code");
                    return false;
                    break;
                    
                    

            }

        }





    }
}
