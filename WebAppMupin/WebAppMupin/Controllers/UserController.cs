using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMupin.Models;

namespace WebAppMupin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
          List<HomeUser> list = getinfo();
            return View("HomeUser",list);
        }


        private List<HomeUser> getinfo()
        {
            MySqlConnection cnn = UtilityDB.connection();
            string query = "SELECT Nome,immagine FROM categoriereperti;";

            List<HomeUser> homeUsers = new List<HomeUser>();

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cnn;
            cnn.Open();
            MySqlDataReader apt = cmd.ExecuteReader();
            while (apt.Read())
            {
                homeUsers.Add(new HomeUser
                {
                    nome = apt["Nome"].ToString(),
                    image = (byte[])apt["immagine"]
                });
                

            }
            cnn.Close();
            return homeUsers;

        }


        public ActionResult logout()
        {

            return RedirectToAction("formLogin", "Login");
        }

        public ActionResult Reperti(string categoria)
        {
            switch (categoria)
            {
                case "computer":
                    {
                        Computer c = new Computer();
                        break;
                    }
                case "":
                    
            }
            // Possibili soluzioni
            //switch tra i model --> creo l'oggetto --> query --> metto i dati in una lista --> passo la lista di model  [più macchinoso , uso i modelli e devo avere una vista per reperto]
            //query sulla categoria -->  dati in una dataTable --> passo la tataTable   [più semplice ma non uso modelli e ho meno controllo]


            return View("ViewReperti");

        }
    }
}