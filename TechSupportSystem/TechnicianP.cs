using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    class TechnicianP
    {
        private int id;
        private String name;
        private String phone;
        private String email;

        public TechnicianP()
        {

        }

        public TechnicianP(int id, String name, String phone, String email)
        {
            this.ID = id;
            this.Name = name;
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

        public String GetDisplayTechnician(String sep)
        {
            return ID + sep + Name + sep + Phone + sep + Email;
        }
    }
}
