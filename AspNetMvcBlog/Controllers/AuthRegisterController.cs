using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class AuthRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
