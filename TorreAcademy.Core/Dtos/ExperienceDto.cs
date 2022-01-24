using System;
using System.Collections.Generic;
using System.Text;

namespace TorreAcademy.Core.Dtos
{
    public class ExperienceDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string FromMonth { get; set; }

        public string ToMonth { get; set; }

        public string FromYear { get; set; }

        public string ToYear { get; set; }

        public string AdditionalInfo { get; set; }

        public bool? Highlighted { get; set; }

        public int? Rank { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? UserId { get; set; }
        public UserDto User { get; set; }

    }
}
