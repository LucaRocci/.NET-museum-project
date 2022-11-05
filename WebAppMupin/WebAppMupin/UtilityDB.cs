﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public static DataTable GetDataTable(string query,MySqlConnection cnn)
        {
            MySqlCommand cmd = new MySqlCommand(query,cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt); 
            return dt;
        }

        public static MySqlDataReader getDataReader(string query,MySqlConnection cnn)
        {
            //devo costruire la query e restituire il dataReader 
        }

      
        public static string buildQuerySelect(string categoria)
        {

            return query;
        }
    }
}