using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projet_Web_Commercial.Controllers
{
    public class PlatController : Controller
    {
        const string chaineCo = @""
        public IActionResult Index()
        {
            var liste = new List<Plat>()
            {
                
            };
            return View(liste);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}