﻿using Core.UserClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs;
using Services.Interfaces;
using Services.Services;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService) 
        {
            _usersService = usersService;
        }


        [HttpGet("all")]
        public IActionResult GetUsers() 
        { 
            List<UserDTO> users = _usersService.GetUsers();
            return users == null ? NotFound() : Ok(users);
        }

        [HttpGet("guests")]
        public IActionResult GetGuests() 
        { 
            List<GuestDTO> guests = _usersService.GetGuests();
            return guests == null ? NotFound() : Ok(guests);
        }

        [HttpGet("admins")]
        public IActionResult GetAdmins() 
        {
            List<AdminDTO> admins = _usersService.GetAdmins();
            return admins == null ? NotFound() : Ok(admins);
        }

        [HttpGet("moderators")]
        public IActionResult GetModerators()
        {
            List<ModeratorDTO> moderators = _usersService.GetModerators();
            return moderators == null ? NotFound() : Ok(moderators);
        }

        [HttpGet("user/{id}")]
        public IActionResult GetUserById(int userId)
        {
            UserDTO userById = _usersService.GetUserById(userId);
            return userById == null ? NotFound() : Ok(userById);
        }

        [HttpPost("create")]

        public void CreateUser(UserDTO user) //////Is "void" a good return????????? shoudl it be IActionResult returning NoContent()??
                                             //////or return CreatedAtAction()???
                                             //////or the user itself???
        {
            _usersService.AddUser(user);
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateUser(int id, UserDTO updatedUser)/////Is this a better approach than the above?  PROBABLY
        {
            bool userUpdated = _usersService.UpdateUser(updatedUser);

            return userUpdated == false ? NotFound() : Ok(updatedUser);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(int userId)
        {
            bool userDeleted = _usersService.DeleteUser(userId);

            return userDeleted == false ? NotFound() : Ok(userId);
        }
    }
}
