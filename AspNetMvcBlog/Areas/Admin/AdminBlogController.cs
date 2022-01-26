using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Areas.Admin
{
    public class AdminBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
