using System;

namespace GamingBlog.Models
{
    public class Contact
    {
        public long ContactID { get; set; }

        public string Name { get; set;}

        public string Email { get; set;}

        public string Subject { get; set;}

        public string Message {get; set;}
     
    }
}