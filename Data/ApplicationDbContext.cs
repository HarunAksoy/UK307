using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamingBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<GamingBlog.Models.Blog> Blogs { get; set; }

        public DbSet<GamingBlog.Models.Contact> Contacts { get; set; }

        public DbSet<GamingBlog.Models.Games> Games  {get; set; }

        public DbSet<GamingBlog.Models.Comment> Logins {get; set; }


    }

}
