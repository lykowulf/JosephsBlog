﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephsBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }


        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public DateTime Crteated { get; set; }
        public DateTime? Updated { get; set; }





        public Blog Blog { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Tag> Tags { get; set; }

    }
}
