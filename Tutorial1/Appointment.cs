using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    public class Appointment
    {
        int patientID;
        int gpID;
        int nurseID;
        String gpAvailability;
        String nurseAvailability;
        DateTime calenderDate;

        public int PatientID { get => patientID; set => patientID = value; }
        public int GpID { get => gpID; set => gpID = value; }
        public int NurseID { get => nurseID; set => nurseID = value; }
        public string GpAvailability { get => gpAvailability; set => gpAvailability = value; }
        public string NurseAvailability { get => nurseAvailability; set => nurseAvailability = value; }
        public DateTime CalenderDate { get => calenderDate; set => calenderDate = value; }
    }
}
