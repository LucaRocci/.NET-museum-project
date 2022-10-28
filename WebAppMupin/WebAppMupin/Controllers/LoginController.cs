using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMupin.Models;

namespace WebAppMupin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult FormLogin()
        {
            Login l = new Login();
            return View(l);
        }


        public ActionResult VerifyUser(Login l)
        {
            if (l.username == null || l.password == null)
            {
                l.message = "Login Fallito... Riprova";
                return View("formLogin", l);
            }
            else
            {
                bool esisteUser = UtilityLogin.verifiyUser(l.username);
                if (!esisteUser)
                {
                    l.message = "Login Fallito... Riprova";
                    return View("formLogin", l);
                }
                else 
                {   
                    int verificaPassword = UtilityLogin.tryLogin(l.username, l.password);
                    if (verificaPassword == 2)
                    {
                        return RedirectToAction("Index", "User");
                    }
                 
                    if (verificaPassword == 1)
                    {
                        setPassword set = new setPassword();
                        set.utente = l.username;
                        return View("setPassword", set);  // situazione di setPassword
                    }
                    else
                    {
                        l.message = "Login Fallito... Riprova";
                        return View("formLogin", l);          //login fallito 
                    }

                }
           
            }
            
        }


        public ActionResult createPassword(setPassword set)
        {
            if(set.Password==null || set.repeatPassword == null)
            {
                set.errorMessage = "Non è possibile lasciare vuoti questi campi";
                return View("setPassword", set);
            }
            if(set.Password.Length<6 || set.repeatPassword.Length < 6)
            {
                set.errorMessage = " Password Troppo Corta ** minimo 6 caratteri";
                return View("setPassword", set);
            }
            if(set.Password != set.repeatPassword)
            {
                set.errorMessage = " Le password non coincidono";
                return View("setPassword", set);
            }
            else
            {
                return View();
            }
           
        }
    }
}