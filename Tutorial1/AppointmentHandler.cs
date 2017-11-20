using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tutorial1
{
    public class AppointmentHandler
    {
        public int addNewAppointment(MySqlConnection conn, Appointment appointment)
        {
            string sql = "INSERT INTO appointment (patientID, gpID, nurseID, gpAvailability, nurseAvailability, date_time)" + "VALUES ('" + appointment.PatientID + "','" + appointment.GpID + "','" + appointment.NurseID + "','" + appointment.GpAvailability + "','" + appointment.NurseAvailability + "','" + appointment.CalenderDate.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}
