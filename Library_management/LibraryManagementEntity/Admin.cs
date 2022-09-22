using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class Admin
    {
        public string AdminEmail { get; set; }

        public int AdminId { get; set; }

        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

         public Admin(string AdminEmail,int AdminId,string AdminName,string AdminPassword)
        {  this.AdminName=AdminName;
           this.AdminId = AdminId;
            this.AdminPassword=AdminPassword;
            this.AdminEmail=AdminEmail;

        }


    }
       
}
