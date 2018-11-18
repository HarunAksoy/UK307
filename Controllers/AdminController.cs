using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GamingBlog.Models;

namespace GamingBlog.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Home()
        {
            return View();
        }

        public string Test(){
            return "This ist testing";
        }
    }
}