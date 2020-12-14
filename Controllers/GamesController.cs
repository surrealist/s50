using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S50.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
