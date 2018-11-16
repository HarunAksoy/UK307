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


        public DBSet<Blog> Blogs { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Games> Game  {get; set; }

        public DbSet<Login> Logins {get; set; }


    }

}
