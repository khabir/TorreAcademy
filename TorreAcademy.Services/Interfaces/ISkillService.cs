using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TorreAcademy.Core.Dtos;

namespace TorreAcademy.Services.Interfaces
{
    public interface ISkillService
    {
        Task<UserWiseSkillDto> GetSkillsByUser(Guid userId);
        Task<List<SkillDto>> GetAllSkills();
    }
}
