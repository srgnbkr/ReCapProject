﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAllUsers();
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetByUserId(id);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);
            
        }

        [HttpPost("add")]
        public IActionResult AddUsers(User user)
        {
            var result = _userService.Add(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult DeleteUsers(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult UpdateUsers(User user)
        {
            var result = _userService.Update(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result.Message);

        }
    }
}
