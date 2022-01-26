using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Areas.Admin
{
    public class AdminUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
