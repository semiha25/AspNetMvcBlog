using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Areas.Admin
{
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
