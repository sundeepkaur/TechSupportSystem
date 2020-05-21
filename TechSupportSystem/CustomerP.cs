using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    class CustomerP
    {
        private int id;
        private String name;
        private String address;
        private String phone;
        private String email;

        public CustomerP()
        {

        }

        public CustomerP(int id, String name, String address, String phone, String email)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String GetDisplayCustomer(String sep)
        {
            return ID + sep + Name + sep + Address + sep + Phone + sep + Email;
        }
    }
}
