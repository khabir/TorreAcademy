using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Entities
{
    public class Experience
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string FromMonth { get; set; }

        public string ToMonth { get; set; }

        public string FromYear { get; set; }

        public string ToYear { get; set; }

        public string AdditionalInfo { get; set; }

        public bool? Highlighted { get; set; }

        public int? Rank { get; set; }

        public Guid? OrganizationId { get; set; }
        public Status Status { get; set; }
        public OrganizationCategory Category { get; set; }

        public Guid? UserId { get; set; }
        public virtual User User { get; set; }

    }
}
