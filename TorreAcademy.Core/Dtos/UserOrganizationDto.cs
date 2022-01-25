using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Dtos
{
    public class UserOrganizationDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid OrganizationId { get; set; }

        public Status Status { get; set; }
        
        public UserDto User { get; set; }
        public OrganizationDto Organization { get; set; }

    }
}
