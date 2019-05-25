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
        [HttpPost]
        public ActionResult Experience(int experienceid,string title,string company,string duration, string expDetail,string departmen,tbl_Experiences _Experience)
        {

            return View();
        }
    public ActionResult Experience()
        {
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