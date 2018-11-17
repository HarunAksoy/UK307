using System;

namespace GamingBlog.Models
{
    public class Blog
    {
        public long Id { get; set; }

        public string Title { get; set; }
     
        public DateTime Releasedate { get; set; }

        public string Content { get; set; }
    }
}

