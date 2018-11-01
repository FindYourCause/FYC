using FYC.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FYC.WebApp.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;
        public BlogController()
        {

        }

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<ActionResult> GetAllBlogPostsByPageIndex()
        {
            var resultData = await _blogService.GetAllBlogByPageIndex(3, 4);
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