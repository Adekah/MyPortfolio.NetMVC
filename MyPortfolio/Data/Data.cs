using MyPortfolio.Models;
using System.Collections.Generic;
using System.Linq;
using System;


namespace MyPortfolio.Data
{
    public class Data
    {

        public static tbl_Profile get_profile(int? id)
        {
            using (PortfolioDBEntities db = new PortfolioDBEntities())
            {
                return db.tbl_Profile.Where(a => a.User_id == id).SingleOrDefault();

            }
        }
        public static tbl_AboutUs get_aboutus(int? id)
        {
            using (PortfolioDBEntities db = new PortfolioDBEntities())
            {
                return db.tbl_AboutUs.Where(a => a.AboutUs_id == id).SingleOrDefault();
            }
        }

        public static List<tbl_Educations> get_education()
        {
            using (PortfolioDBEntities db = new PortfolioDBEntities())
            {
                return db.tbl_Educations.ToList();
            }
        }
        public static List<tbl_Experiences> get_experience()
        {
            using (PortfolioDBEntities db = new PortfolioDBEntities())
            {
                return db.tbl_Experiences.ToList();
            }
        }

        public static tbl_User Login(string username, string password)
        {
            using (PortfolioDBEntities db = new PortfolioDBEntities())
            {
                return db.tbl_User.Where(a => a.Username == username && a.UserPassword == password).SingleOrDefault();
            }
        }
        public static bool SaveExperienceDetail(tbl_Experiences _Experience)
        {
            bool _result = true;
            using (PortfolioDBEntities db = new PortfolioDBEntities())
            {
                try
                {
                    if (_Experience.Experience_id == 0)
                    {
                        _Experience.User_id = 1;
                        db.tbl_Experiences.Add(_Experience);
                    }
                    else
                    {
                        db.tbl_Experiences.Attach(_Experience);
                        db.Entry(_Experience).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    _result = true;
                }

            }
            return _result;
        }
        public static bool SaveAboutus(tbl_AboutUs _AboutUs)
        {
            bool _result = true;
            using (PortfolioDBEntities db = new PortfolioDBEntities())

            {
                try
                {
                    if (_AboutUs.AboutUs_id == 0)
                    {
                        db.tbl_AboutUs.Add(_AboutUs);
                    }
                    else
                    {
                        db.tbl_AboutUs.Attach(_AboutUs);
                        db.Entry(_AboutUs).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    _result = false;
                }
            }
            return _result;
        }



    }
}