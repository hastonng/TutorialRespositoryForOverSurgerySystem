﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tutorial1
{
    public class GPHandler
    {
        public int addNewGP(MySqlConnection conn, GeneralPractitioner gp)
        {
            string sql = "INSERT INTO gp (name, status, date_joined, login_name, password)" + "VALUES ('" + gp.Name + "','" + gp.Status + "','" + gp.DateJoined.ToString("yyyy-MM-dd HH:mm:ss") + "','"+ gp.LoginName+ "','"+gp.Password+"')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}

