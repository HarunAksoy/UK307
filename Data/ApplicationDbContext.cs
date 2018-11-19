using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GamingBlog.Models;
using Bogus;

namespace GamingBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Game> Games  {get; set; }

        public DbSet<Comment> Logins {get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var blogIds = 1;
            var testBlog = new Faker<Blog>()
                .RuleFor(blog => blog.Title, f => f.Lorem.Slug(8))
                .RuleFor(blog => blog.BlogID, () => blogIds++)
                .RuleFor(blog => blog.Releasedate, f => f.Lorem.Slug(8))
                .RuleFor(blog => blog.Content, f => f.Lorem.Slug(8));

        
            var contactIds = 1;
            var testContact = new Faker<Contact>()
                .RuleFor(con => con.Name, f => f.Lorem.Slug(8))
                .RuleFor(con => con.ContactID, () => contactIds++)
                .RuleFor(con => con.Email, f => f.Lorem.Slug(8))
                .RuleFor(con => con.Subject, f => f.Lorem.Slug(8))
                .RuleFor(con => con.Message, f => f.Lorem.Slug(8));

            var gameIds = 1;
            var testGame = new Faker<Game>()
                .RuleFor(gam => gam.Name, f => f.Lorem.Slug(8))
                .RuleFor(gam => gam.GameID, () => gameIds++)
                .RuleFor(gam => gam.Releasedate, f => f.Lorem.Slug(8))
                .RuleFor(gam => gam.Content, f => f.Lorem.Slug(8));
               
            var commentIds = 1;
            var testComment = new Faker<Comment>()
                .RuleFor(comm => comm.Name, f => f.Lorem.Slug(8))
                .RuleFor(comm => comm.CommentId, () => commentIds++)
                .RuleFor(comm => comm.CommentDate, f => f.Lorem.Slug(8))
                .RuleFor(comm => comm.CommentText, f => f.Lorem.Slug(8));

            
            // wird für navigation properties verwendet -> muss anonym geseedet werden
            var blogs = new List<dynamic>();
            var contacts = new List<dynamic>();
            var games = new List<dynamic>();
            var comments = new List<dynamic>();
            
            
            
            //var rnd = new Random();

            foreach(var blog in testBlog.Generate(5)) // thread, thema, Team
            {
                blogs.Add(new
                {
                    BlogID = blog.BlogID, // genau auf die Schreibweise achten! -> kein Intellisense
                    Title = blog.Title,
                    Releasedate = blog.Releasedate,
                    Content = blog.Content
                });
                

                
            }

            foreach(var contact in testContact.Generate(20)) // posts / blogeinträge / Players
            {
                contacts.Add(new
                {
                    //CommentID = (Int64) rnd.Next(1, categoryIds), // zufällig eine Id einer Kategorie auswählen
                    ContactID = contact.ContactID,
                    Name = contact.Name,
                    Email = contact.Email,
                    Subject = contact.Subject,
                    Message = contact.Message
                });
              

            }
                foreach(var game in testGame.Generate(20)) // posts / blogeinträge / Players
            {
                games.Add(new
                {
                    //CommentID = (Int64) rnd.Next(1, categoryIds), // zufällig eine Id einer Kategorie auswählen
                    GameID = game.GameID,
                    Name = game.Name,
                    Releasedate = game.Releasedate,
                    Content = game.Content
                });
              

            }

            foreach(var comment in testComment.Generate(20)) // posts / blogeinträge / Players
            {
                comments.Add(new
                {
                    //CommentID = (Int64) rnd.Next(1, categoryIds), // zufällig eine Id einer Kategorie auswählen
                    CommentId = comment.CommentId,
                    Name = comment.Name,
                    CommentDate = comment.CommentDate,
                    CommentText = comment.CommentText
                });
              

            }

        


             
            modelBuilder.Entity<Blog>().HasData(blogs.ToArray());
            modelBuilder.Entity<Contact>().HasData(contacts.ToArray());
            modelBuilder.Entity<Game>().HasData(games.ToArray());
            modelBuilder.Entity<Comment>().HasData(comments.ToArray());
           
        }
    }
}



    


