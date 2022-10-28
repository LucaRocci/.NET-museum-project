using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebAppMupin
{
    public class UtilityDB
    {
        public static MySqlConnection connection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(WebConfigurationManager.AppSettings["ConnStr"]);
                return conn;
            }catch(MySqlException ex)
            {
                return null;
            }

        }
    }
}