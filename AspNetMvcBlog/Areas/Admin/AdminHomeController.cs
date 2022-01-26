using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Areas.Admin
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
