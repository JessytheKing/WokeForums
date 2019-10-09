using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WokeForums.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DataType Created { get; set; }
        public string ImageUrl { get; set; }

        //LazyLoad Enitiy should take a look at that later
        //Post should be man on forums if they want to post
        public virtual IEnumerable <Post> Posts { get; set; }

    }
}
