using Microsoft.AspNetCore.Mvc;
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
            var data = await userService.GetUsersBySkill(skillId);
            return Ok(data);
        }

        [HttpGet("Users/All")]
        public async Task<IActionResult> GetUsers()
        {
            var data = await userService.GetUsers();
            return Ok(data);
        }
        [HttpGet("user/{userId}/skill/{skillId}")]
        public async Task<IActionResult> GetSkillWiseUserAndSkillDetail(Guid userId, Guid skillId)
        {
            var data = await userService.GetSkillWiseUserAndSkillDetail(userId, skillId);
            return Ok(data);
        }
    }
}
