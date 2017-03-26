using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Class1 class1 = new Class1();
            class1.Prop1 = "prop1";
            var type = DbName.ReadTableName(class1);
            List<PropertyInfo> list = DbName.ReadFieldsInfo(class1);

            List<Class1> l = Class1.GetList();


            return View();
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