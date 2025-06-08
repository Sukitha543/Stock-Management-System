using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private int contactNo;
        private string email;
        private string address;
    

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee(string id,string firstName, string lastName, int contactNo, string email, string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNo = contactNo;
            this.email = email;
            this.address = address;
           
        }
        
        
        
    }
}
