using System;
using System.ComponentModel.DataAnnotations;

namespace GamingBlog.Models
{
    public class Contact
    {
        public long ContactID { get; set; }
        
        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set;}
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set;}
        [Required(ErrorMessage = "The subject is required")]
        public string Subject { get; set;}
        [Required(ErrorMessage = "The message is required")]
        public string Message {get; set;}
     
    }
}