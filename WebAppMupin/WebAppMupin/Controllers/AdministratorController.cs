using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMupin.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            MySqlConnection cnn = UtilityDB.connection();
            string query = "SELECT Nome,Cognome,username FROM utenti WHERE Abilitato=1 AND DefaultPassword!=password;";
            DataTable dt = UtilityDB.GetDataTable(query, cnn);
            return View("HomeAdministrator",dt);
        }
    }
}