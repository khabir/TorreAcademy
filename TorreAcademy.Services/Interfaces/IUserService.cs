using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TorreAcademy.Core.Dtos;

namespace TorreAcademy.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersBySkill(Guid skillId);
    }
}
