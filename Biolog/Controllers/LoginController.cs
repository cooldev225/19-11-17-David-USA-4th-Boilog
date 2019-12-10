using Biolog.Models;
using Biolog.WebReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Biolog.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public JsonResult Index(string username , string password)
        {
            try
            {
                string url = WebConfigurationManager.AppSettings["ReportingServerURL"];
                ReportingService2010 rs = new ReportingService2010();
                //rs.Credentials = System.Net.CredentialCache.DefaultCredentials;
                rs.Credentials = new System.Net.NetworkCredential(username, password, url);
                var items = rs.ListChildren("/", true);//Hoxworth
                int f = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].TypeName.Equals("Report"))
                    {
                        f = 1;
                        break;
                    }
                }
                if (f == 0) return Json("failure");
                User user = new User { Username = username, Password = password, IsLoggedIn = true };
                Session["user"] = user;
                Session.Timeout = 20;
                return Json("success");
            }
            catch (Exception ex)
            {
                return Json("failure");
            }
            
        }

        public ActionResult Logout()
        {
            if (Session["user"] != null)
            {

                Session["user"] = null;

            }
            return RedirectToAction("Index");

        }
    }
}