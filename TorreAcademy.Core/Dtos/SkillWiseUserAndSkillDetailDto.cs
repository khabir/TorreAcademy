using System;
using System.Collections.Generic;
using System.Text;

namespace TorreAcademy.Core.Dtos
{
    public class SkillWiseUserAndSkillDetailDto
    {
        public Guid SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillProficiency { get; set; }

        public List<ExperienceDto> UserExperiences { get; set; } = new List<ExperienceDto>();
        public List<UserDto> RelatedUsers { get; set; } = new List<UserDto>();
    }
}
