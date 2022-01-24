using System;
using System.Collections.Generic;
using System.Text;

namespace TorreAcademy.Core.Dtos
{
    public class UserSkillDto
    {
        public Guid? Id { get; set; }

        public Guid? UserId { get; set; }

        public Guid? SkillId { get; set; }

        public int? Proficiency { get; set; }

        public int? Status { get; set; }
        public UserDto User { get; set; }

    }

}
