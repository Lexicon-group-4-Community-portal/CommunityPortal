﻿using Core;
using Core.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class UsersUserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilePicturePath { get; set; }
        public string Description { get; set; }
        public List<UsersPostDTO> PostHistory { get; set; }
        public int UserExperience { get; set; } //Guest
        public string AdminTitle { get; set; } //Admin
        public int AdminPrivilegeLevel { get; set; } //Admin
        public ModerationArea ModerationArea { get; set; } //Moderator
        public int ModerationExperience { get; set; } //Moderator


    }
}