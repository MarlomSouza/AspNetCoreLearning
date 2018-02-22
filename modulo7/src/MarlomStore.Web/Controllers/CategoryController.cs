
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarlomStore.Web.Models;

namespace MarlomStore.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult CreateOrEdit(int id)
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


    }
}
