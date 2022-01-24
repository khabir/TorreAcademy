﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorreAcademy.Services.Interfaces;

namespace TorreAcademy.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
       
        [HttpGet("GetUsersBySkill/{skillId}")]
        public async Task<IActionResult> GetUsersBySkill(Guid skillId)
        {
            var data= await userService.GetUsersBySkill(skillId);
            return Ok(data);
        }
    }
}