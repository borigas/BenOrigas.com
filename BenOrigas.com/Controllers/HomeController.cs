using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BenOrigas.com.Models;

namespace BenOrigas.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Profile profile = HelperMethods.Deserialize<Profile>(HttpContext.Server.MapPath("~/App_Data/MyProfile.xml"));

            return View("Resume", profile);
        }

        //public ActionResult About()
        //{
        //    return View();
        //}
    }
}
