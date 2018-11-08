using FYC.DataAccess.EFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYC.WebApp.Controllers
{
    public class CountryController : Controller
    {
        private CountryService _CountryService;
        // GET: Country
        public CountryController()
        {
            _CountryService = new CountryService();
        }
        public ActionResult GetCountryById()
        {
            var resultData = _CountryService.GetCountryList();
            if (resultData == null)
            {
                return new HttpNotFoundResult();
            }
            return View(resultData);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}