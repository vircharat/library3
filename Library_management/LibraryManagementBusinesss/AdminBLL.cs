using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementDataa;
using LibraryManagementEntity;

namespace LibraryManagementBusinesss
{
    public class AdminBLL
    {
        
        public bool AdminLogin(string adminEmail,string adminPassword)
        {
            bool flag = false;
            AdminDAL adminDALObj = new AdminDAL();
           // adminDALObj.GetAllAdminsDAL();
            List<Admin>Admins1=adminDALObj.GetAllAdminsDAL();

            foreach(var item in Admins1)
            {
                if (item.AdminEmail == adminEmail && item.AdminPassword == adminPassword)
                {
                    flag= true;
                    break;
                }


            }
            return flag;
        }
    }
}
