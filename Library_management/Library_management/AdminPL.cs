using LibraryManagementDataa;
using LibraryManagementBusinesss;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class AdminPL
    { 
        public void menu()
        {
            Console.WriteLine("Welcome to ABC Library Management System\n" +
             "1)Press 1 to login as Admin\n" +
             "2)Press 2 to login as User\n" +
             "3)Press 3 to exit\n");

            int codeentered;
            codeentered=Convert.ToInt32(Console.ReadLine());
           
            switch (codeentered)
            {
                case 1:
                    AdminPL adminPLObj = new AdminPL();
                    adminPLObj.AdminLogin();
                    break;
                case 2:
                    UserPL userPLObj = new UserPL();
                    userPLObj.UserLogin();
                    break;
                case 3:
                    Console.WriteLine("Thank you");
                    break;
                default:
                    Console.WriteLine("Invalid Code");
                    break;
            }

        }
        public void AcceptRequest()
        {

        }

        public void AdminLogin()
        {
            string AdminEmail;
            string AdminPassword;
            Console.Write("Email :");
            AdminEmail = Console.ReadLine();
            Console.Write("Password :");
            AdminPassword = Console.ReadLine();
            AdminBLL adminBLLObj = new AdminBLL();

            bool flag=adminBLLObj.AdminLogin(AdminEmail,AdminPassword);
            if(flag)
            {
                Console.WriteLine("Logged in Successfully as admin");
                AdminPL adminPlObj = new AdminPL();
                adminPlObj.AdminSection();

            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }


        }
        private void AdminSection()
        {
            Console.WriteLine("Welcome-to-Admin-Section");
            int codeentered;
            // int codebooksection, usersection, requestsection, acceptedsection, logout;
            Console.WriteLine("Press 1 to show book section");
            Console.WriteLine("Press 2 to show user section");
            Console.WriteLine("Press 3 to show request section");
            Console.WriteLine("Press 4 to show accepted section");
            Console.WriteLine("Press 5 to logout");
            codeentered =Convert.ToInt32(Console.ReadLine());
            UserPL userPLObj=new UserPL();
            AdminPL adminPLObj=new AdminPL();
            switch(codeentered)
            {
                case 1:
                    BookPL bookPLObj = new BookPL();
                    bookPLObj.BookSection();

                    break;
                case 2:
                    bool flag = true;
                    while(flag)
                    {
                        flag=userPLObj.UserSection(flag);
                    }

                        break;
                case 3:
                    adminPLObj.RequestedSection();
                    break;
                case 4:
                    
                    break;
                case 5:
                    break;
                default : 
                    Console.WriteLine("invalid code");
                    break;

            }

            


        }

        public void DeleteRecieved()
        {

        }

        public void GetAdminMenu()
        {


        }

        public void RecievedSection()
        {

        }

        public void RequestedSection()
        {

        }
    }
}
