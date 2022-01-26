using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class PageDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
