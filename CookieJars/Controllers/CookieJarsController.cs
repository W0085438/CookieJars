using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieJars.Controllers
{
    public class CookieJarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
