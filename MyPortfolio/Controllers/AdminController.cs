using MyPortfolio.Models;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class AdminController : Controller
    {
        PortfolioDBEntities db = new PortfolioDBEntities();

        // GET: Admin
        public ActionResult AdminIndex()
        {
            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AboutUs(int aboutusid, string aboutus,tbl_AboutUs _Aboutus)
        {
            _Aboutus.AboutUs_id = aboutusid;
            _Aboutus.AboutUs = aboutus;

      Data.Data.SaveAboutus(_Aboutus);
            return View();
        }
     
        public ActionResult Aboutus()
        {

            if (Session["AdminUser"] == null)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            tbl_AboutUs aboutus = Data.Data.get_aboutus(1);
            ViewBag.Aboutus = aboutus.AboutUs;

            return View();
        }

        public ActionResult Experience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Experience(tbl_Experiences _Experience,FormCollection formexperience)
        {

            _Experience.Company = formexperience["input_company_name"];
            _Experience.Duration = formexperience["input_duration_name"];
            _Experience.ExperienceDetail = formexperience["input_experienceDetail_name"];
            _Experience.Title = formexperience["input_title_name"];
            Data.Data.SaveExperienceDetail(_Experience);
            return View();
        }
   

        [HttpPost]
        public ActionResult Adminlogin(string username, string password)
        {
            tbl_User user = Data.Data.Login(username, password);

            if (user != null)
            {
                Session["AdminUser"] = user;
                return RedirectToAction("AdminIndex", "Admin");
            }

            return View();
        }
    }
}