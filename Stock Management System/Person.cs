using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal abstract class Person:Interface
    {   
        //Account creation and login credentials
        protected string username;
        protected string id;
        protected string password;

        public string Username {
            get { return username;} 
            set { username = value;} 
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

       public Person()
        {

        }

        public Person(string username,string id,string password) 
        {
            this.username = username;
            this.id = id;
            this.password = password;
        }

        public Person(string username,string password) 
        {
            this.username = username;
            this.password=password;
        }

        public abstract void create(string username, string id, string password);
        public abstract void login(string username,string password);

       

    }

}
