using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TorreAcademy.Core.Data;
using TorreAcademy.Core.Dtos;
using TorreAcademy.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TorreAcademy.Services.Services
{
    public class SkillService: ISkillService
    {
        private readonly TorreAcademyDbContext dbContext;
        private readonly IMapper mapper;

        public SkillService(TorreAcademyDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<SkillDto>> GetSkillsByUser(Guid userId)
        {
            var skills = await (from skill in dbContext.Skills
                                join userSkill in dbContext.UserSkills on skill.Id equals userSkill.SkillId
                                where userSkill.UserId == userId
                                select skill).ToListAsync();

            return mapper.Map<List<SkillDto>>(skills);
        }
    }
}
