using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace olympic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //var AppRoleManager = new BusinessLogic.Identity.AppliasdasdcationRoleManager();
            //var result = AppRoleManager.Create("Admin");

            //var user = new BusinessLogic.Identity.ApplicationUser()
            //{
            //    UserName = "administrator",
            //    Email = "admin@olympicpayroll.com",
            //    FirstName = "Administrator",
            //    LastName = "OlympicPayroll",
            //};

            //var AppUserManager = new BusinessLogic.Identity.ApplicationUserManager();
            //AppUserManager.Authenticate("administrator", "Olympic@Payroll");
            //bool addUserResult = AppUserManager.Create(user, "password");

            //LoginController proc = new LoginController();
            //proc.Authenticate(new LoginRequest { UserName = "administrator", Password = "Olympic@Payroll" });
            return View();
        }
    }
}
