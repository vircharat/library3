using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class User
    {
        public string UserEmail { get; set; }
        public int UserId { get; set; }

        public string UserName { get; set; }    
        public string UserPassword { get; set; }

       /* public User(string UserName,int UserId,string AdminPassword, string AdminEmail)
        {
            this.UserName = UserName;
            this.UserId = UserId;
            this.UserPassword = AdminPassword;
            this.UserEmail = AdminEmail;

        }*/
       public User()
        {

        }

    }
}
