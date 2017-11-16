using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tutorial1
{
    public class ReceptionistHandler
    {
        public int addNewReceptionist(MySqlConnection conn, Receptionist receptionist)
        {
            string sql = "INSERT INTO receptionist (name, status, date_joined, login_name, password)" + "VALUES ('"+ receptionist.Name + "','" + receptionist.Status + "','" + receptionist.Datejoined.ToString("yyyy-MM-dd HH:mm:ss") + "','" + receptionist.LoginName + "','" + receptionist.Password + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}
