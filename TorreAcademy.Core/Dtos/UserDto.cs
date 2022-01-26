using System;
using System.Collections.Generic;
using System.Text;
using TorreAcademy.Core.Enum;

namespace TorreAcademy.Core.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public string ProfilePicture { get; set; }

        public DateTime? CreatedDate { get; set; }
        public Status Status { get; set; }
        public ExperienceDto RecentExperience { get; set; }
    }
}
