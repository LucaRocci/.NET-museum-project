using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMupin.Models;
using WebAppMupin.Models.Reperti;

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
            MySqlConnection cnn = UtilityDB.connection();
            List<string> colonne= UtilityDB.getDataColumn(cnn, categoria);
            string query = UtilityReperti.generateQuerySelect(categoria,colonne);


            switch (categoria)
            {
                case "computer":
                    {
                        List<Computer> listComp = UtilityReperti.getDataReader(query,cnn).ToComputer();
                        break;
                    }
                case "rivista":
                    {
                        Rivista r = new Rivista();
                        break;

                    }
                case "software":
                    {
                        Software s = new Software();
                        break;

                    }
                case "libro":
                    {
                        Libro l = new Libro();
                        break;
                    }
                case "periferica":
                    {
                        Periferica p = new Periferica();
                        break;
                    }
                default:
                    {
                        return RedirectToAction("Index", "User");
                  
                    }

            }

         
        }
    }
}