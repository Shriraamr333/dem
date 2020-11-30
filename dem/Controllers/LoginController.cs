using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dem.ViewModels;

namespace dem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            if (avm.account.Username.Equals("abc") && avm.account.Password.Equals("123"))
            {
                Session["username"] = avm.account.Username;
                return RedirectToAction("Order", "Home");
            }
            else
            {
                ViewBag.Error = "Account is Invalid";
                return View("Index");
            }
        }
    }
}