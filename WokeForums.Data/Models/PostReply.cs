using System;
using System.Collections.Generic;
using System.Text;

namespace WokeForums.Data.Models
{
    public class PostReply
    {
        public int Id  { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public virtual AppUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}
