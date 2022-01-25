using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Dtos
{
    public class UserSkillDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid SkillId { get; set; }

        public Proficiency Proficiency { get; set; }

        public Status Status { get; set; }
        public UserDto User { get; set; }
        public SkillDto Skill { get; set; }

    }

}
