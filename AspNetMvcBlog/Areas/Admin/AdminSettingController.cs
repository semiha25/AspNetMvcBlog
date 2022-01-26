using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Areas.Admin
{
    public class AdminSettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
