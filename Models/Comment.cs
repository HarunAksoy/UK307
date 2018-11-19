using System;

namespace GamingBlog.Models
{
    public class Comment
    {
        public long CommentId { get; set; }       

        public string Name { get; set; }

        public string CommentDate { get; set; }

        public string CommentText { get; set; }     
     
    }
}