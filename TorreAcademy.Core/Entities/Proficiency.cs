using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Entities
{
    public class Proficiency
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }
        public int Order { get; set; }

    }
}
