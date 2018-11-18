using CoffeeManagement.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;

namespace CoffeeManagement.Controllers
{
    public class LoginController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(Session["username"] != null)
            {
                filterContext.HttpContext.Response.Redirect("~/Home", true);
            }
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthorizeLogin(Models.Account accout)
        {
            CoffeeShopDBEntities db = new CoffeeShopDBEntities();
            //if (db.ValidateUser(accout.Username, accout.Password))
            //{
            //    return RedirectToAction("Index", "Home");
            //}

            //return View("Index");
            var result = db.ValidateUser(accout.Username, accout.Password);
            foreach(bool x in result)
            {
                if(x == true)
                {
                    var a = db.Accounts.Find(accout.Username);
                    var e = db.Employees.Find(a.Username);
                    if(a.Status == true)
                    {
                        Session["fullname"] = e.Name.ToString();
                        Session["username"] = a.Username;
                        Session["position"] = e.Position.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}