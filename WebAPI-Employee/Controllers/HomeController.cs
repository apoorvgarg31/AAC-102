using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebAPI_Employee.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(dbo__vUsers model, string returnUrl)
        {
            CommodityInfoEntities cm = new CommodityInfoEntities();
            var dataItem = cm.dbo__vUsers.Where(x => x.UserName == model.UserName &&
                                                    x.Password == model.Password && x.IsActive == "Active").FirstOrDefault();
            if(dataItem != null)
            {
                FormsAuthentication.SetAuthCookie(dataItem.UserName, false);
                if(Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") 
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }  
            else
            {
                ViewBag.message = "Invalid Credentials";
                return View();

            }
            
        }
        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }

    }
}
