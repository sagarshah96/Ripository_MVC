using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Core;
using Repository.Service.Providers;
using Repository.Service.Services;

namespace Repositry_MVC.Controllers
{
    public class HomeController : Controller
    {
        ITestService _TS = new TestService();


        public ActionResult Index()
        {
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

        public ActionResult AddEdit()
        {
            ViewBag.Country = new SelectList(_TS.GetCountry(), "CountryId", "Name");
            IEnumerable<SelectListItem> values = from enumDepartment d in Enum.GetValues(typeof(enumDepartment))
                                                 select new SelectListItem
                                                 {
                                                     Text = d.ToString(),
                                                     Value = Convert.ToInt32(d).ToString()
                                                 };
            ViewBag.Department = new SelectList(values, "Value", "Text");
            IEnumerable<SelectListItem> lstHobby = from Hobby h in Enum.GetValues(typeof(Hobby))
                                                   select new SelectListItem
                                                   {
                                                       Text = h.ToString(),
                                                       Value = h.ToString()
                                                   };
            ViewBag.Hobby = new SelectList(lstHobby, "Text", "Text");
            return View();
        }

        public ActionResult GetState(int CountryId)
        {
            var States = _TS.GetStates(CountryId);
            return Json(States, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCity(int StateId)
        {
            var City = _TS.GetCity(StateId);
            return Json(City, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetHobby()
        {
            IEnumerable<SelectListItem> lstHobby = from Hobby h in Enum.GetValues(typeof(Hobby))
                                                 select new SelectListItem
                                                 {
                                                     Text = h.ToString(),
                                                     Value = h.ToString()
                                                 };
            ViewBag.Hobby = new SelectList(lstHobby, "Text", "Text");
            return View();
        }
    }
}