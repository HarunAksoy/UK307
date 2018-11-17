using System;

namespace GamingBlog.Models
{
    public class Comment
    {
        public long Id { get; set; }       

        public string PersonName { get; set; }

        public DateTime CommentDate { get; set; }

        public string CommentText { get; set; }     
     
    }
}