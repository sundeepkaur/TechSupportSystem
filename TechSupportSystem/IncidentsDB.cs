using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    class IncidentsDB
    {
        private static Incident[] incidents = new Incident[5];
        public static int count = 0;
        public static bool AddIncident(Incident incident)
        {
            bool success = false;
            try
            {
                incidents[count++] = incident;
                success = true;
            }
            catch
            {
                throw new Exception("Database is Full, Cannot Add more Incidents");

            }
            return success;
        }

        public static bool CloseIncident(Incident incident)
        {
            return true;
        }

        public static bool OpenIncident(Incident incident)
        {
            return true;
        }

        public static Incident[] GetIncidents()
        {
            return incidents;
        }
    }
}
