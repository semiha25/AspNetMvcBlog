﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class AuthForgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
