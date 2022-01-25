using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public virtual UserSkill UserSkill { get; set; }
        public Status Status { get; set; }

    }
}
