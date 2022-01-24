using System;
using System.Collections.Generic;
using System.Text;

namespace TorreAcademy.Core.Dtos
{
    public class SkillDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Proficiency { get; set; }

    }

}
