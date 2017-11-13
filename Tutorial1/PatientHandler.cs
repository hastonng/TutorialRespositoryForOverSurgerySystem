using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class PatientHandler
    {
        public int addNewPatient(MySqlConnection conn, Patient p)
        {
            string sql = "INSERT INTO patient (name, myKadNo, age)" + "VALUES ('" + p.Name + "','" + p.Mykad + "','" + p.Age + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}
