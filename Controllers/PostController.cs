using System;
using GamingBlog.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GamingBlog.Models;
using Microsoft.AspNetCore.Authorization;

namespace GamingBlog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult NewPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewPost(BlogViewModel viewModel )
        {
            var Blog = new Blog (){
            Title = viewModel.Title,
            Content = viewModel.Content,
            Releasedate = viewModel.Releasedate
            };
            _context.Add(Blog); 
            _context.SaveChanges();
            return RedirectToAction("NewPost");
        }

        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
