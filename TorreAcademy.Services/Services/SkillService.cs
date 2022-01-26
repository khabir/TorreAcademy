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
using TorreAcademy.Core.Enum;

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

        public async Task<List<SkillDto>> GetAllSkills()
        {
            var skills = await (from skill in dbContext.Skills
                                where skill.Status == Status.Active
                                select skill).ToListAsync();

            return mapper.Map<List<SkillDto>>(skills);
        }

        public async Task<UserWiseSkillDto> GetSkillsByUser(Guid userId)
        {
            var proficiencyWiseSkills = new List<ProficiencyWiseSkill>();

            var skillList = await (from skill in dbContext.Skills
                                   join userSkill in dbContext.UserSkills on skill.Id equals userSkill.SkillId
                                   join usr in dbContext.Users on userSkill.UserId equals usr.Id
                                   join prof in dbContext.Proficiencies on userSkill.ProficiencyId equals prof.Id
                                   join userExp in dbContext.Experiences on usr.Id equals userExp.UserId
                                   where userSkill.UserId == userId && userExp.Highlighted == true
                                   orderby prof.Order
                                   select new { UserId = usr.Id, usr.FirstName, usr.LastName, usr.Email, usr.Phone, usr.Status, usr.ProfilePicture, RecentDesignation = userExp.Name, SkillId = skill.Id, SkillName = skill.Name, Proficiency = prof.Name }).ToListAsync();


            if (skillList.Count() == 0) return null;

            var skillGroup = skillList.GroupBy(x => x.Proficiency);

            foreach (var grp in skillGroup)
            {
                var model = new ProficiencyWiseSkill();

                var proficiency = grp.Key;

                model.Proficiency = grp.Key;

                foreach (var item in grp)
                {
                    model.Skills.Add(new SkillDto { Id = item.SkillId, Name = item.SkillName});
                }
                proficiencyWiseSkills.Add(model);
            }

            var user = skillList.FirstOrDefault();
            var output = new UserWiseSkillDto { FirstName = user.FirstName, LastName = user.LastName, 
                Email = user.Email, Phone= user.Phone, Status = user.Status.ToString(), UserId = user.UserId, ProfilePicture = user.ProfilePicture, 
                ProficiencyWiseSkills = proficiencyWiseSkills,
                RecentExperience = new ExperienceDto
                {
                    Name = user.RecentDesignation
                }
            };

            return output;
        }
    }
}
