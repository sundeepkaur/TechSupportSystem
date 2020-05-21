using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    public class Customer
    {
        private int id;
        private String name;
        private String streetName;
        private int streetNumber;
        private String city;
        private String province;
        private String postalCode;
        private String phone;
        private String email;

        public Customer()
        {

        }

        public Customer(int id, String name, String stName, int stNumber, String city, String province, String postalCode, String phone, String email)
        {
            this.ID = id;
            this.Name = name;
            this.StreetName = stName;
            this.StreetNumber = stNumber;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
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

        public String StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }


        public int StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
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
            return ID + sep + Name + sep + StreetNumber + sep + streetName + sep + City + sep + Province + sep + PostalCode + sep + Phone + sep + Email;
        }
    }
}
