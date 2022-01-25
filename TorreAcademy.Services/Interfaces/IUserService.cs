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
        Task<List<UserDto>> GetUsers();
        Task<SkillWiseUserAndSkillDetailDto> GetSkillWiseUserAndSkillDetail(Guid userId, Guid skillId);
    }
}
