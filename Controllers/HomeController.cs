using System;
using GamingBlog.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GamingBlog.Models;
using System.Data.SqlClient;


namespace GamingBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contact()
        {
            

            return View();
        }


        public IActionResult Games()
        {
            return View();
        }
        
        public IActionResult Blog()
        {
            return View (from blog in _context.Blogs.Take(10)
                         select blog);
        }

 
            
        


        [HttpPost]
        public IActionResult Contact(ContactViewModel viewModel)
        {
            var newContact = new Contact(){
                Name = viewModel.Name,
                Email = viewModel.Email,
                Subject = viewModel.Subject,
                Message = viewModel.Message
            };
            _context.Add(newContact);
            _context.SaveChanges();
            return RedirectToAction("Contact");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
