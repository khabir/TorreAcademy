using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Dtos
{
    public class UserWiseSkillDto
    {
        public Guid? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public List<ProficiencyWiseSkill> ProficiencyWiseSkills { get; set; }
    }

    public class ProficiencyWiseSkill
    {
        public string Proficiency { get; set; }
        public List<SkillDto> Skills { get; set; } = new List<SkillDto>();
    }
}
