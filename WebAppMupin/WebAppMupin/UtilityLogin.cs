using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebAppMupin
{
    public static class UtilityLogin
    {

        public static int tryLogin(string Username,string Password)
        {
           MySqlConnection cnn=  UtilityDB.connection();

            string query = "SELECT password FROM utenti WHERE  username=@us AND Abilitato=1;";
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.Parameters.AddWithValue("us@", Username);
            cmd.CommandText = query;
            
            cnn.Open();
            MySqlDataReader read= cmd.ExecuteReader();
            // procedura di verifica password
            if(read.Read())
            {
                string passBD = read.GetString(0);
                bool verified = BCrypt.Net.BCrypt.Verify(Password,passBD);
                if (verified)
                {
                    return 2;   // logged 
                }
                else
                {
                    return 0;   // passsword don't match 
                }
            }                      
                else
                return 1;   // password don't find 
            cnn.Close();
        }

        public static bool verifiyUser(string username)  
        {
            MySqlConnection cnn = UtilityDB.connection();
            string query = "SELECT ID FROM utenti WHERE username= @us AND Abilitato=1;";
            MySqlCommand cmd= cnn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@us", username);
            try
            {
                cnn.Open();
                MySqlDataReader read= cmd.ExecuteReader();
                if( read.Read())
                {
                    return true; // user exist
                }
                else
                {
                    return false;  // user doesn't exist 
                }
            }catch(MySqlException ex)
            {
                return false;
            }
           
        }

        public static bool insertPassword(string password,string username)
        {
            return true;

            return false;

        }

    }
}