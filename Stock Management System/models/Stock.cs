using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Stock
    {
        private string id;
        private string name;
        private int quantity;
        private string supplier;
        private int contact;
        private DateTime date;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public Stock(string id, string name,int quantity,string supplier,int contact, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.supplier = supplier;
            this.contact = contact;
            this.date = DateTime.Now;
        }
       

    }
}
