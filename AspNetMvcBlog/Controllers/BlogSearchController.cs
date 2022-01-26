using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class BlogSearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
