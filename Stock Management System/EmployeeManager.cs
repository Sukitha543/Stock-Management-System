using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{

    internal class EmployeeManager : Person, Interface
    {
        

        public EmployeeManager(string username, string id, string password) : base(username, id, password)
        {
        }

        public EmployeeManager(string username, string password) : base(username, password)
        {
        }

        public override void create(string username, string id, string password)
        {
            
        }

        public override void login(string username, string password)
        {
            
        }  
    }
}
