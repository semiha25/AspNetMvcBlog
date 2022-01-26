using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class AuthLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
