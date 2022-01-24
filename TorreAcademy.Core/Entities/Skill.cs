using System;
using System.Collections.Generic;
using System.Text;

namespace TorreAcademy.Core.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public virtual UserSkill UserSkill { get; set; }

    }

}
