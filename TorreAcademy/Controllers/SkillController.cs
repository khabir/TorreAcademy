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
    public class SkillController : ControllerBase
    {
        private readonly ISkillService skillService;

        public SkillController(ISkillService skillService)
        {
            this.skillService = skillService;
        }

        [HttpGet("GetSkillsByUser/{userId}")]
        public async Task<IActionResult> GetSkillsByUser(Guid userId)
        {
            var data = await skillService.GetSkillsByUser(userId);
            return Ok(data);
        }

        [HttpGet("Skills/All")]
        public async Task<IActionResult> GetSkills()
        {
            var data = await skillService.GetAllSkills();
            return Ok(data);
        }
    }
}
