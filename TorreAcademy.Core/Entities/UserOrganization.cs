using System;
using System.Collections.Generic;
using System.Text;

namespace TorreAcademy.Core.Entities
{
    public class UserOrganization
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid OrganizationId { get; set; }

        public int Status { get; set; }
        
        public virtual User User { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
