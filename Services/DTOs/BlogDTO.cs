﻿using Core.CommunityClasses;
using Core.NewsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class BlogDTO
    {
        public int PostId { get; set; }
        public UserDTO User { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int BlogId { get; set; } //Blog
        public string BlogTitle { get; set; } //Blog
        public BlogCategory BlogCategory { get; set; } //Blog

    }
}