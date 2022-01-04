using Dynamically_loading_contents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dynamically_loading_contents.Controllers
{
    public class HomeController : Controller
    {
        Dynamically_loadingEntities db = new Dynamically_loadingEntities();

        public ActionResult Index()
        {
            return View(db.tbl_employee.ToList());
        }

        public ActionResult tbl_employee(int id)
        {
            List<tbl_employee> emp = db.tbl_employee.Where(x => x.emp_id == id).ToList();
            return View(emp);
        }

              

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}