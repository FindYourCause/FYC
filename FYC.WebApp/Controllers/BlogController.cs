using FYC.DataAccess.EFServices;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FYC.WebApp.Controllers
{
    public class BlogController : Controller
    {
        private BlogService _BlogService;
        public BlogController()
        {
            _BlogService = new BlogService();
        }
        public ActionResult GetAllBlogPostsByPageIndex()
        {
            var resultData = _BlogService.GetAllCategories(1, 1);
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