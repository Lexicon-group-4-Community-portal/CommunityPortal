﻿using Core.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class GuestDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilePicturePath { get; set; }
        public string Description { get; set; }
        public List<PostDTO> PostHistory { get; set; }
        public int UserExperience { get; set; } //Guest

    }
}
