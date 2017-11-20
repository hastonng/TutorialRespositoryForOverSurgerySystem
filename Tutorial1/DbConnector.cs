using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tutorial1
{
    public class DbConnector
    {
        MySqlConnection conn;

        public string connect()
        {
            MySqlConnectionStringBuilder builder    = new MySqlConnectionStringBuilder();
            builder.Server                          = "localhost";
            builder.Port                            = 3306;
            builder.Database                        = "oversurgerydb";
            builder.UserID                          = "dbcli";
            builder.Password                        = "dbcli123";

            conn = new MySqlConnection( builder.ConnectionString );
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                return e.ToString();
            }

            return "Done";
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
        
    }
}
