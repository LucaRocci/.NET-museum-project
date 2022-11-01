using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMupin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
           MySqlConnection cnn= UtilityDB.connection();
            string query = "SELECT Nome,immagine FROM categoriereperti;";
            DataTable dt = UtilityDB.GetDataTable(query,cnn);

            return View("HomeUser",dt);
        }
    }
}