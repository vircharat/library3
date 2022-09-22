using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementDataa;
using LibraryManagementEntity;

namespace Library_management
{
    internal class Program
    {
        static void Main(string[] args)
        {

             AdminPL adminPLObj = new AdminPL();
               adminPLObj.menu();
            
            //Reflextion meta data : data about data

         /*   Type type = typeof(Book);
            var members=type.GetMembers();
            var methods=type.GetMethods();
            var propInfo = type.GetProperties();
            var t= "";
            Activator
             */
           
            Console.Read();

           


        }
    }
}
