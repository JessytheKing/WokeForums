using System;
using System.Collections.Generic;
using System.Text;

namespace WokeForums.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual AppUser User { get; set; }
        //Relates to 
        public virtual Forum Forum { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }

    }
}
