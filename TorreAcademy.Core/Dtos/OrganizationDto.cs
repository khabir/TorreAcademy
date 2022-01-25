using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Dtos
{
    public class OrganizationDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PublicId { get; set; }
        public Status Status { get; set; }
    }

}
