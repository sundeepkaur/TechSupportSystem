using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    public class Incident
    {
        private int id;
        private int customerId;
        private int productId;
        private int technicianId;
        private String dateOpen;
        private String dateClose;
        private String title;

        public Incident()
        {

        }

        public Incident(int id, int custId, int prodId, int techId, String dateOpen, String dateClose, String title)
        {
            this.ID = id;
            this.CustomerID = custId;
            this.ProductID = prodId;
            this.TechnicianID = techId;
            this.DateOpen = dateOpen;
            this.DateClose = dateClose;
            this.Title = title;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int CustomerID
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        public int TechnicianID
        {
            get { return technicianId; }
            set { technicianId = value; }
        }

        public String DateOpen
        {
            get { return dateOpen; }
            set { dateOpen = value; }
        }

        public String DateClose
        {
            get { return dateClose; }
            set { dateClose = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String GetDisplayIncidents(String sep)
        {
            return ID + sep + CustomerID + sep + ProductID + sep + TechnicianID + sep + DateOpen + sep + DateClose + sep + Title;
        }
    }
}
