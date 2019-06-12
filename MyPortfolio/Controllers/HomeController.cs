using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;
using MyPortfolio.Models;
using System.Net;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        PortfolioDBEntities db = new PortfolioDBEntities();


        // GET: Home
        public ActionResult Index()
        {
            ViewBag.User = Data.Data.get_profile(1);
            ViewBag.AboutUs = Data.Data.get_aboutus(1);
            ViewBag.EducationInfo = Data.Data.get_education();
            ViewBag.ExperienceInfo = Data.Data.get_all_experience();
            return View();
        }
    }
}