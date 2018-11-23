using System;
using System.ComponentModel.DataAnnotations;

namespace GamingBlog.Models
{
    public class BlogViewModel
    {
        
        public long BlogID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Releasedate { get; set; }
        [Required]
        public string Content { get; set; }
    }
}

